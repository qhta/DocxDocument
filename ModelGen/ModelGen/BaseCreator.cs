

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

  public void RunOn(Type type, ProcessOptions options)
  {
    TypeManager.Clear();
    Options = options;
    IsRun = true;
    var displayOptions = Options.DisplayOptions;
    if (displayOptions == null)
      displayOptions = new DisplayOptions();
    var stopAtPhase = (PPS)Enum.ToObject(typeof(PPS), Options.StopAtPhase);
    var monitorDisplaySelector = Options.Display;

    ModelMonitor?.ShowProcessStart($"Start processing {type}");
    SourceAssembly = type.Assembly;
    TotalTypesCount = SourceAssembly.ExportedTypes.Count();
    TimeSpan totalTime = TimeSpan.Zero;

    PhaseDone = PPS.None;
    if (stopAtPhase >= PPS.ScanSource)
    {
      totalTime += ScanType(type);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      PhaseDone = PPS.ScanSource;
    }

    if (stopAtPhase >= PPS.AddDocs)
    {
      totalTime += AddDocs();
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanSource, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanSource, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      PhaseDone = PPS.AddDocs;
    }

    if (stopAtPhase >= PPS.Rename)
    {
      totalTime += RenameTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeRename))
        ModelMonitor?.ShowTypeRenames();
      PhaseDone = PPS.ScanSource;
    }

    if (stopAtPhase >= PPS.ConvertTypes)
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
    ModelMonitor?.ShowPhaseStart(PPS.ScanSource, "Scanning types");
    DateTime t1 = DateTime.Now;
    ModelManager.OnScanningType += ModelManager_OnScanningType;
    ModelManager.ScanType(type);
    ModelManager.OnScanningType -= ModelManager_OnScanningType;

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var allTypesCount = TypeManager.AllTypes.Count();
    var acceptedTypesCount = TypeManager.TypesAcceptedAfter(PPS.ScanSource).Count();
    var rejectedTypesCount = TypeManager.TypesRejectedAfter(PPS.ScanSource).Count();
    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.RegisteredTypes, allTypesCount },
        {SummaryInfoKind.AcceptedTypes, acceptedTypesCount },
        {SummaryInfoKind.RejectedTypes, rejectedTypesCount },
        }
    };

    ModelMonitor?.ShowPhaseEnd(PPS.ScanSource, summaryInfo);
    return ts;
  }

  private void ModelManager_OnScanningType(RegisterProgressInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanSource, new ProgressInfo
    {
      PreStr = "registered",
      TotalTypes = TotalTypesCount,
      ProcessedTypes = info.RegisteredTypes,
      Namespaces = info.RegisteredNamespaces,
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });;
  }

  protected TimeSpan AddDocs()
  {
    ModelMonitor?.ShowPhaseStart(PPS.AddDocs, "Adding documentation");
    DateTime t1 = DateTime.Now;

    int typesWithAddedDescriptionCount = 0;
    if (Options.UseModelDocFile && !String.IsNullOrEmpty(Options.ModelDocFileName))
    {
      var ModelDocumenter = new ModelDocsManager(PPS.AddDocs, NTS.Origin, MSS.Accepted, Options.ModelDocFileName);
      ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType; 
      typesWithAddedDescriptionCount = ModelDocumenter.DocumentTypes();
      ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;
    }

    var ModelValidator = new ModelValidator(PPS.AddDocs, NTS.Origin, MSS.Accepted, TDS.Metadata);
    ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    ModelValidator.ValidateTypes(PPS.AddDocs);
    ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var typesWithDescriptionCount = TypeManager.TypesAcceptedTo(PPS.AddDocs)
      .Count(item=>item.Description!=null);
    var typesWithoutDescriptionCount = TypeManager.TypesAcceptedTo(PPS.AddDocs)
      .Count(item=>item.HasError(PPS.AddDocs, ErrorCode.MissingDescription));
    var typesWithMeaninglessDescriptionCount = TypeManager.TypesAcceptedTo(PPS.AddDocs)
      .Count(item=>item.HasError(PPS.AddDocs, ErrorCode.MeaninglessDescription));

    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.TypesWithDescription, typesWithDescriptionCount},
        {SummaryInfoKind.TypesWithAddedDescription, typesWithAddedDescriptionCount},
        {SummaryInfoKind.TypesWithoutDescription, typesWithoutDescriptionCount},
        {SummaryInfoKind.TypesWithMeaninglessDescription, typesWithMeaninglessDescriptionCount},
        }
    };

    ModelMonitor?.ShowPhaseEnd(PPS.AddDocs, summaryInfo);
    return ts;
  }

  private void ModelDocumenter_OnDocumentingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.AddDocs, new ProgressInfo
    {
      PreStr = "added docs to",
      TotalTypes = info.TotalTypes,
      CheckedTypes = info.CheckedTypes,
      ProcessedTypes =  info.ProcessedTypes,
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });;
  }

  private void ModelValidator_OnValidatingType(ModelValidator sender, ValidatingTypeInfo info)
  {
    //ModelMonitor?.ShowPhaseProgress(PPS.ScanSource, new ProgressInfo
    //{
    //  PreStr = "validated",
    //  Done = info.CheckedTypes,
    //  Total = info.TotalTypes,
    //  MidStr = "types",
    //  Summary = new Dictionary<string, object>{
    //    {"invalid", info.InvalidTypes ?? 0 } },
    //  PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    //});
  }

  protected TimeSpan RenameTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.Rename, "Renaming types");
    DateTime t1 = DateTime.Now;
    ModelManager.OnRenamingType += ModelManager_OnRenamingType;
    var renamedTypesCount = ModelManager.RenameNamespacesAndTypes();
    ModelManager.OnRenamingType -= ModelManager_OnRenamingType;

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.ShowPhaseEnd(PPS.Rename, new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.AllTypes, TypeManager.AllTypes.Count() },
        {SummaryInfoKind.RenamedTypes, renamedTypesCount },
        {SummaryInfoKind.ProblematicTypes, ModelManager.DuplicateTypeNamesCount},
        }
    });
    return ts;
  }

  private void ModelManager_OnRenamingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.Rename, new ProgressInfo
    {
      PreStr = "renamed",
      TotalTypes = TotalTypesCount,
      CheckedTypes = info.CheckedTypes,
      ProcessedTypes = info.ProcessedTypes,
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName} -> {info.Current?.GetTargetNamespace()}.{info.Current?.Name}"
    });
  }

  protected TimeSpan ConvertTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.ConvertTypes, "Converting types");
    DateTime t1 = DateTime.Now;
    ModelManager.OnConvertingType += ModelManager_OnConvertingType;
    var renamedTypesCount = ModelManager.ConvertTypes();
    ModelManager.OnConvertingType -= ModelManager_OnConvertingType;

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.ShowPhaseEnd(PPS.ConvertTypes, new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.AllTypes, TypeManager.AllTypes.Count() },
        {SummaryInfoKind.ConvertedTypes, renamedTypesCount },
        {SummaryInfoKind.ProblematicTypes, TypeManager.AllTypes.Count(item=>item.HasProblems(PhaseDone))},
        }
    });
    return ts;
  }

  private void ModelManager_OnConvertingType(ProgressTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ConvertTypes, new ProgressInfo
    {
      PreStr = "converted",
      TotalTypes = TotalTypesCount,
      ProcessedTypes = info.ProcessedTypes,
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
    using (var xmlWriter = XmlWriter.Create(filename, new XmlWriterSettings{ Indent=true }))
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

