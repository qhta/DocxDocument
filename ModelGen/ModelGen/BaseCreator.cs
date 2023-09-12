

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

  public bool IsRun { get; set; }

  public PPS PhaseDone { get; private set; }

  public ModelMonitor? ModelMonitor { get; set; }

  public BaseCreator(string projectName, string outputPath)
  {
    ProjectName = projectName;
    OutputPath = outputPath;
  }

  public void RunProcess(ProcessOptions options)
  {
    var assembly = Assembly.Load("DocumentFormat.OpenXml");
    Debug.Assert(assembly != null);
    Type? rootType = assembly.GetType(options.ScanTypeName, true);
    Debug.Assert(rootType != null);
    RunOn(rootType, options);//(PPS)Enum.ToObject(typeof(PPS), options.StopAtPhase), options.Display, options.DisplayOptions);
  }

  protected ProcessOptions Options { get; set; } = new ProcessOptions();

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
  public void RunOn(Type type, ProcessOptions options)
  {
    TypeManager.Clear();
    Options = options;
    IsRun = true;
    //var displayOptions = Options.DisplayOptions;
    //if (displayOptions == null)
    var displayOptions = new DisplayOptions();

    var monitorDisplaySelector = Options.Display;

    ModelMonitor?.ShowProcessStart(String.Format(CommonStrings.StartProcessing_0.DecodeEscapeSeq(), type.FullName));
    SourceAssembly = type.Assembly;
    TotalTypesCount = SourceAssembly.ExportedTypes.Count();
    TimeSpan totalTime = TimeSpan.Zero;

    PhaseDone = PPS.None;
    if (StopAtPhase >= PPS.ScanSource)
    {
      totalTime += ScanType(type);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      PhaseDone = PPS.ScanSource;
    }

    if (StopAtPhase >= PPS.AddDocs)
    {
      totalTime += AddDocs();
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      PhaseDone = PPS.AddDocs;
    }

    if (StopAtPhase >= PPS.Rename)
    {
      totalTime += RenameTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeRename))
        ModelMonitor?.ShowTypeRenames();
      PhaseDone = PPS.ScanSource;
    }

    if (StopAtPhase >= PPS.ConvertTypes)
    {
      totalTime += ConvertTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeConversions))
        ModelMonitor?.ShowTypeConversions();
      PhaseDone = PPS.ConvertTypes;
    }

    //totalTime += CheckTypeUsage();
    //if (monitorDisplaySelector.HasFlag(MDS.TypeUsage))
    //  ModelMonitor?.ShowNamespacesDetails(displayOptions ?? new DisplayOptions());

    //totalTime += ValidateTypes();
    //if (monitorDisplaySelector.HasFlag(MDS.ValidatedTypes))
    //  ModelMonitor?.ShowNamespacesDetails(displayOptions ?? new DisplayOptions());

    //totalTime += GenerateCode();

    ModelMonitor?.ShowProcessSummary(new SummaryInfo
    {
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
    if (Options.ValidateScan)
    {
      var ModelValidator = new ModelValidator(PPS.ScanSource, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      if (!ModelValidator.ValidateTypes(PPS.ScanSource))
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
    ModelMonitor?.ShowPhaseStart(PPS.AddDocs, CommonStrings.AddDocs);
    DateTime t1 = DateTime.Now;

    int typesWithAddedDescriptionCount = 0;
    if (Options.UseModelDocFile && !String.IsNullOrEmpty(Options.ModelDocFileName))
    {
      var ModelDocumenter = new ModelDocsManager(PPS.AddDocs, NTS.Origin, MSS.Accepted, Options.ModelDocFileName);
      ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;
      typesWithAddedDescriptionCount = ModelDocumenter.DocumentTypes();
      ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;
    }

    bool validated = false;
    var typesWithoutDescriptionCount = 0;
    var typesWithMeaninglessDescriptionCount = 0;
    if (Options.ValidateDocs)
    {
      var ModelValidator = new ModelValidator(PPS.AddDocs, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      ModelValidator.ValidateTypes(PPS.AddDocs);
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
      Args = new object[] { info.CheckedTypes ?? 0, info.TotalTypes ?? 0, info.ProcessedTypes ?? 0 },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    }); ;
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

  protected TimeSpan RenameTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.Rename, CommonStrings.RenameTypes);
    DateTime t1 = DateTime.Now;
    ModelManager.OnRenamingType += ModelManager_OnRenamingType;
    var renamedTypesCount = ModelManager.RenameNamespacesAndTypes();
    ModelManager.OnRenamingType -= ModelManager_OnRenamingType;

    var invalidTypes = 0;
    if (Options.ValidateNames)
    {
      var ModelValidator = new ModelValidator(PPS.Rename, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      if (!ModelValidator.ValidateTypes(PPS.Rename))
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
        {TypeInfoKind.AllTypes, TypeManager.AllTypes.Count() },
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
    var convertedTypesCount = ModelManager.ConvertTypes();
    ModelManager.OnConvertingType -= ModelManager_OnConvertingType;

    var invalidTypes = 0;
    if (Options.ValidateNames)
    {
      var ModelValidator = new ModelValidator(PPS.ConvertTypes, NTS.Origin, MSS.Accepted, TDS.Metadata);
      ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
      if (!ModelValidator.ValidateTypes(PPS.Rename))
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
        {TypeInfoKind.AllTypes, TypeManager.AllTypes.Count() },
        {TypeInfoKind.ConvertedTypes, convertedTypesCount },
        }
    };

    if (invalidTypes > 0)
      summaryInfo.Summary.Add(TypeInfoKind.InvalidTypes, invalidTypes);

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

  //protected TimeSpan CheckTypeUsage()
  //{
  //  ModelMonitor?.ShowPhaseStart("Checking types usage");
  //  DateTime t1 = DateTime.Now;
  //  ModelManager.OnCheckingUsage += ModelManager_OnCheckingUsage;
  //  foreach (var type in TypeManager.AcceptedTypes.ToArray())
  //  {
  //    ModelManager.CheckTypeUsage(type);
  //  }
  //  ModelManager.OnCheckingUsage -= ModelManager_OnCheckingUsage;
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  var usedTypesCount = TypeManager.UsedTypes.Count();
  //  var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
  //  ModelMonitor?.ShowPhaseEnd("Checking type usage", new SummaryInfo
  //  {
  //    Time = ts,
  //    Summary = new Dictionary<string, object>{
  //      {"Used types", usedTypesCount },
  //      {"Accepted types", acceptedTypesCount },
  //      }
  //  });
  //  return ts;
  //}

  //protected TimeSpan ValidateTypes()
  //{
  //  ModelMonitor?.ShowPhaseStart("Validating types & namespaces");
  //  DateTime t1 = DateTime.Now;
  //  var checkedTypesCount = 0;
  //  var checkedNamespacesCount = 0;
  //  var fixedTypesCount = 0;
  //  var duplicateTypesCount = 0;
  //  foreach (var typeInfo in TypeManager.AllTypes.ToArray())
  //  {
  //    ModelMonitor?.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName(true, true, true)}");
  //    if (!ModelManager.ValidateType(typeInfo))
  //      fixedTypesCount++;
  //  }
  //  //invalidTypesCount += ModelManager.CheckNamespacesDuplicatedTypesAsync((int repaired, int waiting)
  //  //  =>
  //  //  ModelMonitor?.WriteSameLine($"Repaired {repaired} types. Waiting for {waiting} namespaces ")
  //  //  );
  //  foreach (var nspace in TypeManager.GetNamespaces(NTS.Target))
  //  {
  //    ModelMonitor?.WriteSameLine($"Checked {++checkedNamespacesCount} namespaces for duplicate type names. {nspace}");
  //    int n = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
  //    if (n > 0)
  //      duplicateTypesCount += n;
  //  }
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  ModelMonitor?.ShowPhaseEnd("Validating types & namespaces", new SummaryInfo
  //  {
  //    Time = ts,
  //    Summary = new Dictionary<string, object>{
  //      {"Fixed types", fixedTypesCount },
  //      {"Duplicated types", duplicateTypesCount },
  //      }
  //  });
  //  return ts;
  //}

  protected abstract TimeSpan GenerateCode();
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

