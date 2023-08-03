

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
    if (stopAtPhase >= PPS.ScanTypes)
    {
      totalTime += ScanType(type);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(PPS.ScanTypes, NTS.Origin);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(PPS.ScanTypes, displayOptions with { NamespaceTypeSelector = NTS.Origin });
      PhaseDone = PPS.ScanTypes;
    }

    if (stopAtPhase >= PPS.RenameTypes)
    {
      totalTime += RenameTypes();
      if (monitorDisplaySelector.HasFlag(MDS.TypeRename))
        ModelMonitor?.ShowTypeRenames();
      PhaseDone = PPS.ScanTypes;
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
    ModelMonitor?.ShowPhaseStart(PPS.ScanTypes, "Scanning types");
    DateTime t1 = DateTime.Now;
    ModelManager.OnScanningType += ModelManager_OnScanningType;
    ModelManager.ScanType(type);
    ModelManager.OnScanningType -= ModelManager_OnScanningType;

    int? documentedTypesCount = null;
    if (Options.UseModelDocFile && !String.IsNullOrEmpty(Options.ModelDocFileName))
    {
      var ModelDocumenter = new ModelDocumenter(NTS.Origin, MSS.Accepted, Options.ModelDocFileName);
      ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;
      documentedTypesCount = ModelDocumenter.DocumentTypes(PPS.ScanTypes);
      ModelDocumenter.OnDocumentingType += ModelDocumenter_OnDocumentingType;
    }

    var ModelValidator = new ModelValidator(PPS.ScanTypes, NTS.Origin, MSS.Accepted, TDS.Metadata);
    ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    ModelValidator.ValidateTypes(PPS.ScanTypes);
    ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var allTypesCount = TypeManager.AllTypes.Count();
    var acceptedTypesCount = TypeManager.TypesAcceptedAfter(PPS.ScanTypes).Count();
    var rejectedTypesCount = TypeManager.TypesRejectedAfter(PPS.ScanTypes).Count();
    var summaryInfo = new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.RegisteredTypes, allTypesCount },
        {SummaryInfoKind.AcceptedTypes, acceptedTypesCount },
        {SummaryInfoKind.RejectedTypes, rejectedTypesCount },
        }
    };
    if (documentedTypesCount!=null)
      summaryInfo.Summary.Add(SummaryInfoKind.DocumentedTypes, documentedTypesCount);
    summaryInfo.Summary.Add(SummaryInfoKind.InvalidTypes, ModelValidator.InvalidTypesCount);

    ModelMonitor?.ShowPhaseEnd(PPS.ScanTypes, summaryInfo);
    return ts;
  }

  private void ModelManager_OnScanningType(ScanningTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanTypes, new ProgressInfo
    {
      Total = TotalTypesCount,
      PreStr = "registered",
      Done = info.RegisteredTypes,
      MidStr = "types",
      Summary = new Dictionary<string, object>{
        {"in {0} namespaces", info.RegisteredNamespaces ?? 0 } },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

  private void ModelDocumenter_OnDocumentingType(ModelDocumenter sender, DocumentingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanTypes, new ProgressInfo
    {
      PreStr = "documenting",
      Done = info.CheckedTypes,
      Total = info.TotalTypes,
      MidStr = "types",
      Summary = new Dictionary<string, object>{
        {"documented", info.DocumentedTypes ?? 0 } },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

  private void ModelValidator_OnValidatingType(ModelValidator sender, ValidatingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanTypes, new ProgressInfo
    {
      PreStr = "validated",
      Done = info.CheckedTypes,
      Total = info.TotalTypes,
      MidStr = "types",
      Summary = new Dictionary<string, object>{
        {"invalid", info.InvalidTypes ?? 0 } },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

  protected TimeSpan RenameTypes()
  {
    ModelMonitor?.ShowPhaseStart(PPS.RenameTypes, "Renaming types");
    DateTime t1 = DateTime.Now;
    ModelManager.OnRenamingType += ModelManager_OnRenamingType;
    var renamedTypesCount = ModelManager.RenameNamespacesAndTypes();
    ModelManager.OnRenamingType -= ModelManager_OnRenamingType;

    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.ShowPhaseEnd(PPS.RenameTypes, new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.AllTypes, TypeManager.AllTypes.Count() },
        {SummaryInfoKind.RenamedTypes, renamedTypesCount },
        {SummaryInfoKind.InvalidTypes, ModelManager.DuplicateTypeNamesCount},
        }
    });
    return ts;
  }

  private void ModelManager_OnRenamingType(RenamingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.RenameTypes, new ProgressInfo
    {
      Total = TotalTypesCount,
      PreStr = "renamed",
      Done = info.RenamedTypes,
      MidStr = "types",
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
        {SummaryInfoKind.InvalidTypes, TypeManager.AllTypes.Count(item=>!item.IsValid(PhaseDone))},
        }
    });
    return ts;
  }

  private void ModelManager_OnConvertingType(ConvertingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ConvertTypes, new ProgressInfo
    {
      Total = TotalTypesCount,
      PreStr = "converted",
      Done = info.ConvertedTypes,
      MidStr = "types",
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


  private void ModelManager_OnCheckingUsage(CheckingUsageInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.UsageCheck, new ProgressInfo
    {
      PreStr = "checked",
      Done = info.CheckedTypes,
      MidStr = "types",
      Summary = new Dictionary<string, object>{
        {"used", info.UsedTypes ?? 0 } },
      PostStr = $"{info.Current?.OriginalNamespace}.{info.Current?.OriginalName}"
    });
  }

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

