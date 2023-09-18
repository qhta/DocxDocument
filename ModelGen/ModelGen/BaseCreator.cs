

namespace ModelGen;

/// <summary>
/// Base creator containing common methods for both specific creators.
/// </summary>
public abstract class BaseCreator
{
  /// <summary>
  /// Assembly of DocumentFormat.OpenXml.dll
  /// </summary>
  protected Assembly SourceAssembly { get; set; } = null!;

  /// <summary>
  /// Total count of types in SourceAssembly
  /// </summary>
  protected int TotalTypesCount { get; set; }

  /// <summary>
  /// Name of the C# project. Base of the namespace.
  /// </summary>
  protected string ProjectName { get; set; }

  /// <summary>
  /// Base path of directories to create the structure of the output files.
  /// </summary>
  protected string OutputPath { get; set; }


  public bool CancelRequest
  {
    get => ModelManager.CancelRequest;
    set
    {
      ModelManager.CancelRequest = value;
      CodeGenerator.CancelRequest = value;
    }
  }

  public bool IsRun { get; set; }

  public PPS PhaseDone { get; private set; }

  public ModelMonitor? ModelMonitor { get; set; }

  public BaseCodeGenerator CodeGenerator { get; set; } = null!;

  public BaseCreator(string projectName, string outputPath)
  {
    ProjectName = projectName;
    OutputPath = outputPath;
  }

  public void RunProcess(ProcessOptions options, bool continueProcess = false)
  {
    if (continueProcess && PhaseDone > PPS.None)
    {
      Debug.Assert(RootType != null);
      RunOn(RootType, options, true);
    }
    else
    {
      var assembly = Assembly.Load("DocumentFormat.OpenXml");
      Debug.Assert(assembly != null);
      RootType = assembly.GetType(options.ScanTypeName, true);
      Debug.Assert(RootType != null);
      RunOn(RootType, options);
    }
  }

  protected ProcessOptions Options { get; set; } = new ProcessOptions();

  protected Type? RootType = null!;

  public PPS StopAtPhase
  {
    get
    {
      return _StopAtPhase ??
        (PPS)Enum.ToObject(typeof(PPS), Options.StopAtPhase);
    }
    set { _StopAtPhase = value; }
  }
  private PPS? _StopAtPhase = null!;

  public bool CanContinue => PhaseDone < StopAtPhase;

  public virtual void RunOn(Type type, ProcessOptions options, bool continueProcess = false)
  {
    Options = options;
    IsRun = true;

    var displayOptions = new DisplayOptions();

    var monitorDisplaySelector = MDS.None;

    if (CancelRequest)
      return;
    ModelMonitor?.ShowProcessStart(
        (continueProcess ? CommonStrings.ProcessContinue : CommonStrings.ProcessStart) + ":\n" + type.FullName);
    SourceAssembly = type.Assembly;
    TotalTypesCount = SourceAssembly.ExportedTypes.Count();
    TimeSpan totalTime = TimeSpan.Zero;
    if (!continueProcess)
      PhaseDone = PPS.None;

    if (!continueProcess)
      TypeManager.Clear();

    if (StopAtPhase >= PPS.ScanSource && PhaseDone < PPS.ScanSource && !CancelRequest)
    {
      totalTime += ScanType(type);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      if (!CancelRequest)
        PhaseDone = PPS.ScanSource;
    }

    if (StopAtPhase >= PPS.AddDocs && PhaseDone < PPS.AddDocs && !CancelRequest)
    {
      totalTime += AddDocs();
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      if (!CancelRequest)
        PhaseDone = PPS.AddDocs;
    }

    if (StopAtPhase >= PPS.Rename && PhaseDone < PPS.Rename && !CancelRequest)
    {
      totalTime += RenameNamespacesAndTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeRename))
        ModelMonitor?.ShowTypeRenames();
      if (!CancelRequest)
        PhaseDone = PPS.Rename;
    }

    if (StopAtPhase >= PPS.ConvertTypes && PhaseDone < PPS.ConvertTypes && !CancelRequest)
    {
      totalTime += ConvertTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeConversions))
        ModelMonitor?.ShowTypeConversions();
      if (!CancelRequest)
        PhaseDone = PPS.ConvertTypes;
    }

    ModelMonitor?.ShowProcessSummary(new SummaryInfo
    {
      ProcessCancelled = CancelRequest,
      Time = totalTime
    });
    IsRun = false;
  }

  #region Processing methods

  protected TimeSpan ScanType(Type type)
  {
    ModelMonitor?.ShowPhaseStart(PPS.ScanSource, CommonStrings.ScanSource);
    DateTime t1 = DateTime.Now;
    ModelManager.OnScanningType += ModelManager_OnScanningType;
    ModelManager.ScanType(type);
    ModelManager.OnScanningType -= ModelManager_OnScanningType;

    var checkedTypesCount = 0;
    var validTypesCount = 0;
    var invalidTypesCount = 0;
    if (Options.ValidateScan && !CancelRequest)
    {
      var ModelValidator = new ModelValidator(PPS.ScanSource, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      var types = TypeManager.AllTypes.Where(type => type.IsAcceptedAfter(PPS.ScanSource)).ToArray();
      if (!ModelValidator.ValidateTypes(PPS.ScanSource, types))
        invalidTypesCount = ModelValidator.InvalidTypesCount;
      checkedTypesCount = ModelValidator.CheckedTypesCount;
      validTypesCount = ModelValidator.ValidTypesCount;
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var allTypesCount = TypeManager.AllTypes.Count();
    var acceptedTypesCount = TypeManager.TypesAcceptedAfter(PPS.ScanSource).Count();
    var rejectedTypesCount = TypeManager.TypesRejectedAfter(PPS.ScanSource).Count();
    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<TypeInfoKind, object>{
        {TypeInfoKind.RegisteredTypes, allTypesCount },
        {TypeInfoKind.AcceptedTypes, acceptedTypesCount },
        {TypeInfoKind.RejectedTypes, rejectedTypesCount },
        }
    };
    if (checkedTypesCount > 0 || validTypesCount > 0 || invalidTypesCount > 0)
    {
      summaryInfo.Summary.Add(TypeInfoKind.CheckedTypes, checkedTypesCount);
      summaryInfo.Summary.Add(TypeInfoKind.ValidTypes, validTypesCount);
      summaryInfo.Summary.Add(TypeInfoKind.InvalidTypes, invalidTypesCount);
    }
    ModelMonitor?.ShowPhaseEnd(PPS.ScanSource, summaryInfo);
    return ts;
  }

  private void ModelManager_OnScanningType(RegisterProgressInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanSource, new ProgressInfo
    {
      FormatStr = CommonStrings.registered_0_of_1_types_in_2_namespaces,
      Args = new object[] { info.RegisteredTypes ?? 0, TotalTypesCount, info.RegisteredNamespaces ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    }); ;
  }

  protected TimeSpan AddDocs()
  {
    if (String.IsNullOrEmpty(Options.ModelDocFileName))
      return new TimeSpan(0);
    ModelMonitor?.ShowPhaseStart(PPS.AddDocs, CommonStrings.AddDocs);
    DateTime t1 = DateTime.Now;
    int checkedTypesCount = 0;
    int typesWithAddedDescriptionCount = 0;
    var ModelDocumenter = new ModelDocsManager(PPS.AddDocs, NTS.Origin, MSS.Accepted, Options.ModelDocFileName);
    ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;
    var types = TypeManager.AllTypes.Where(typeInfo => typeInfo.IsAcceptedTo(PPS.AddDocs)
              && typeInfo.OriginalNamespace.StartsWith("DocumentFormat")
              && !typeInfo.IsGenericTypeDefinition).ToArray();
    checkedTypesCount = TotalTypesCount = types.Count();
    typesWithAddedDescriptionCount = ModelDocumenter.DocumentTypes(types);
    ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;

    bool validated = false;
    var typesWithoutDescriptionCount = 0;
    var typesWithMeaninglessDescriptionCount = 0;
    if (Options.ValidateDocs && !CancelRequest)
    {
      var ModelValidator = new ModelValidator(PPS.AddDocs, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      ModelValidator.ValidateTypes(PPS.AddDocs, types);
      typesWithoutDescriptionCount = TypeManager.TypesAcceptedTo(PPS.AddDocs)
        .Count(item => item.HasError(PPS.AddDocs, ErrorCode.MissingDescription));
      typesWithMeaninglessDescriptionCount = TypeManager.TypesAcceptedTo(PPS.AddDocs)
        .Count(item => item.HasError(PPS.AddDocs, ErrorCode.MeaninglessDescription));
      validated = true;
      ModelValidator.OnValidatingType -= ModelValidator_OnValidatingType;
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var typesWithDescriptionCount = TypeManager.TypesAcceptedTo(PPS.AddDocs)
      .Count(item => item.Description != null);


    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<TypeInfoKind, object>{
        {TypeInfoKind.CheckedTypes, checkedTypesCount},
        {TypeInfoKind.TypesWithDescription, typesWithDescriptionCount},
        {TypeInfoKind.TypesWithAddedDescription, typesWithAddedDescriptionCount},
        }
    };
    if (validated)
    {
      summaryInfo.Summary.Add(TypeInfoKind.TypesWithoutDescription, typesWithoutDescriptionCount);
      summaryInfo.Summary.Add(TypeInfoKind.TypesWithMeaninglessDescription, typesWithMeaninglessDescriptionCount);
    }
    ModelMonitor?.ShowPhaseEnd(PPS.AddDocs, summaryInfo);
    return ts;
  }

  private void ModelDocumenter_OnDocumentingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.AddDocs, new ProgressInfo
    {
      FormatStr = CommonStrings.adding_docs_0_of_1_types_added_to_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, TotalTypesCount, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

  private void ModelValidator_OnValidatingType(ModelValidator sender, ValidatingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(sender.PhaseNum, new ProgressInfo
    {
      FormatStr = CommonStrings.verifying_0_of_1_types_invalid_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.InvalidTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

  protected TimeSpan RenameNamespacesAndTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.Rename, CommonStrings.RenameTypes);
    DateTime t1 = DateTime.Now;
    ModelManager.OnRenamingType += ModelManager_OnRenamingType;
    var types = TypeManager.AllTypes.Where(typeInfo => typeInfo.IsAcceptedTo(PPS.Rename)
              && typeInfo.OriginalNamespace.StartsWith("DocumentFormat")
              && !typeInfo.IsGenericTypeDefinition).ToArray();
    TotalTypesCount = types.Count();
    var renamedTypesCount = ModelManager.RenameNamespacesAndTypes(types);
    ModelManager.OnRenamingType -= ModelManager_OnRenamingType;

    var invalidTypes = 0;
    if (Options.ValidateNames && !CancelRequest)
    {
      var ModelValidator = new ModelValidator(PPS.Rename, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      if (!ModelValidator.ValidateTypes(PPS.Rename, types))
      {
        invalidTypes = ModelValidator.InvalidTypesCount;
      }
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<TypeInfoKind, object>{
        {TypeInfoKind.CheckedTypes, TotalTypesCount},
        {TypeInfoKind.RenamedTypes, renamedTypesCount },
        }
    };

    if (invalidTypes > 0)
      summaryInfo.Summary.Add(TypeInfoKind.InvalidTypes, invalidTypes);

    ModelMonitor?.ShowPhaseEnd(PPS.Rename, summaryInfo);
    return ts;
  }

  private void ModelManager_OnRenamingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.Rename, new ProgressInfo
    {
      FormatStr = CommonStrings.renaming_0_of_1_types_renamed_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName} -> {info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }

  protected TimeSpan ConvertTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.ConvertTypes, CommonStrings.ConvertTypes);
    DateTime t1 = DateTime.Now;
    ModelManager.OnConvertingType += ModelManager_OnConvertingType;
    var types = TypeManager.AllTypes.Where(typeInfo => typeInfo.IsAcceptedTo(PPS.ConvertTypes)
              && typeInfo.OriginalNamespace.StartsWith("DocumentFormat")
              && !typeInfo.IsGenericTypeDefinition).ToArray();
    var convertedTypesCount = ModelManager.ConvertTypes(types);
    ModelManager.OnConvertingType -= ModelManager_OnConvertingType;

    var targetTypesCount = 0;
    var invalidTypesCount = 0;
    if (Options.ValidateConversion && !CancelRequest)
    {
      var ModelValidator = new ModelValidator(PPS.ConvertTypes, NTS.Target, MSS.Accepted, TDS.Metadata);
      var newNS = TypeManager.AllNamespaces.Where(ns => ns.IsTarget).ToArray();
      var newTypes = TypeManager.AllNamespaces.Where(ns => ns.IsTarget)
        .SelectMany(ns=>ns.Types)
        .Where(typeInfo=>!typeInfo.IsGenericTypeDefinition).ToArray().ToArray();
      targetTypesCount = newTypes.Count();
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      if (!ModelValidator.ValidateTypes(PPS.ConvertTypes, newTypes))
      {
        invalidTypesCount = ModelValidator.InvalidTypesCount;
      }
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<TypeInfoKind, object>{
        {TypeInfoKind.CheckedTypes, TotalTypesCount },
        {TypeInfoKind.ConvertedTypes, convertedTypesCount },
        }
    };

    if (targetTypesCount > 0)
      summaryInfo.Summary.Add(TypeInfoKind.TargetTypes, targetTypesCount);
    if (invalidTypesCount > 0)
      summaryInfo.Summary.Add(TypeInfoKind.InvalidTypes, invalidTypesCount);

    ModelMonitor?.ShowPhaseEnd(PPS.ConvertTypes, summaryInfo);
    return ts;
  }

  private void ModelManager_OnConvertingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ConvertTypes, new ProgressInfo
    {
      FormatStr = CommonStrings.converting_0_of_1_types_converted_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName} -> {info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }

  protected TimeSpan GenerateCode()
  {
    ModelMonitor?.ShowPhaseStart(PPS.ConvertTypes, CommonStrings.GenerateCode);
    DateTime t1 = DateTime.Now;
    CodeGenerator.OnGeneratingType += ModelManager_OnConvertingType;
    var nspaces = TypeManager.AllNamespaces.Where(item=>item.IsTarget);
    var generatedTypesCount = CodeGenerator.GenerateCode(nspaces);
    CodeGenerator.OnGeneratingType -= ModelManager_OnConvertingType;

    var invalidTypes = 0;
    if (Options.ValidateConversion && !CancelRequest)
    {
      //var ModelValidator = new ModelValidator(PPS.ConvertTypes, NTS.Origin, MSS.Accepted, TDS.Metadata);
      //ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      //if (!ModelValidator.ValidateTypes(PPS.ConvertTypes, types))
      //{
      //  invalidTypes = ModelValidator.InvalidTypesCount;
      //}
      //ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    }

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<TypeInfoKind, object>{
        {TypeInfoKind.CheckedTypes, TotalTypesCount },
        {TypeInfoKind.GeneratedTypes, generatedTypesCount },
        }
    };

    if (invalidTypes > 0)
      summaryInfo.Summary.Add(TypeInfoKind.InvalidTypes, invalidTypes);

    ModelMonitor?.ShowPhaseEnd(PPS.CodeGeneration, summaryInfo);
    return ts;
  }

  private void ModelManager_OnGeneratingCode(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ConvertTypes, new ProgressInfo
    {
      FormatStr = CommonStrings.converting_0_of_1_types_converted_2_types,
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName} -> {info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }
  #endregion

  #region monitoring callbacks



  //private void TypeReflector_OnReflection(ReflectionInfo info)
  //{
  //  ModelMonitor?.ShowPhaseProgress("Scanning types", new ProgressInfo
  //  {
  //    PreStr = "reflected",
  //    Done = info.Done,
  //    MidStr = "types",
  //    Summary = new Dictionary<string, object>{
  //      {"waiting", info.Waiting ?? 0 } },
  //    PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
  //  });
  //}


  //private void ModelManager_OnCheckingUsage(TypeProcessInfo info)
  //{
  //  ModelMonitor?.ShowPhaseProgress(PPS.UsageCheck, new ProgressInfo
  //  {
  //    PreStr = "checked",
  //    Done = info.CheckedTypes,
  //    MidStr = "types",
  //    Summary = new Dictionary<string, object>{
  //      {"used", info.UsedTypes ?? 0 } },
  //    PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
  //  });
  //}

  #endregion

  #region SaveData
  public void SaveData()
  {
    SaveData(GetFilename());
  }

  public void SaveData(string filename)
  {
    using (var xmlWriter = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
    {
      var xmlSerializer = new QXmlSerializer(typeof(BaseCreator));
      xmlSerializer.Serialize(xmlWriter, this);
    }
  }

  public string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, $"Phase {PhaseDone} result.xml");
    return path;
  }
  #endregion

}

