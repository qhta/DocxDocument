using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;

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
    RunOn(rootType, (PPS)Enum.ToObject(typeof(PPS), options.StopAtPhase), options.Display, options.DisplayOptions);
  }

  public void RunOn(Type type, PPS stopAtPhase, MDS monitorDisplaySelector = MDS.None, DisplayOptions? displayOptions = null)
  {
    IsRun = true;
    if (displayOptions == null)
      displayOptions = new DisplayOptions();
    ModelMonitor?.ShowProcessStart($"Start processing {type}");
    SourceAssembly = type.Assembly;
    TotalTypesCount = SourceAssembly.ExportedTypes.Count();
    TimeSpan totalTime = TimeSpan.Zero;

    if (stopAtPhase >= PPS.ScanTypes)
    {
      totalTime += ScanType(type);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
        ModelMonitor?.ShowNamespaceSummary(NTS.Origin);
    }

    if (stopAtPhase >= PPS.ScanValidation)
    {
      totalTime += ValidateScan(NTS.Origin, displayOptions.TypeStatusSelector, displayOptions.TypeDataSelector);
      if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
        ModelMonitor?.ShowNamespacesDetails(displayOptions with { NamespaceTypeSelector = NTS.Origin });
    }

    //totalTime += RenameTypes();
    //if (monitorDisplaySelector.HasFlag(MDS.TypeRename))
    //  ModelMonitor?.ShowTypeRenames();

    //totalTime += SetTypeConversions();
    //if (monitorDisplaySelector.HasFlag(MDS.TypeConversions))
    //  ModelMonitor?.ShowTypeConversions();

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
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var allTypesCount = TypeManager.AllTypes.Count();
    //var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    var rejectedTypesCount = TypeManager.RejectedTypes.Count();
    ModelMonitor?.ShowPhaseEnd(PPS.ScanTypes, new SummaryInfo
    {
      Time = ts,
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.RegisteredTypes, allTypesCount },
        {SummaryInfoKind.AcceptedTypes, acceptedTypesCount },
        {SummaryInfoKind.RejectedTypes, rejectedTypesCount }
        }
    });
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
  protected TimeSpan ValidateScan(NTS nameTypeSelector, MSS typeStatusSelector, TDS typeDataSelector)
  {
    ModelMonitor?.ShowPhaseStart(PPS.ScanValidation, "Validating scan");
    DateTime t1 = DateTime.Now;
    var ModelValidator = new ModelValidator(nameTypeSelector, typeStatusSelector, typeDataSelector);
    ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    ModelValidator.ValidateTypes();
    ModelValidator.OnValidatingType += ModelValidator_OnValidatingType;
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.ValidatedTypes, ModelValidator.CheckedTypesCount },
        {SummaryInfoKind.ValidTypes, ModelValidator.ValidTypesCount }, 
        {SummaryInfoKind.InvalidTypes, ModelValidator.CheckedTypesCount-ModelValidator.ValidTypesCount }, 
      };
    if (ModelValidator.NoDocsTypesCount > 0)
      summary.Add(SummaryInfoKind.TypesWithoutDocumentation, ModelValidator.NoDocsTypesCount);
    if (ModelValidator.NoSummaryTypesCount > 0)
      summary.Add(SummaryInfoKind.TypesWithoutSummary, ModelValidator.NoSummaryTypesCount);
    ModelMonitor?.ShowPhaseEnd(PPS.ScanValidation, new SummaryInfo
    {
      Time = ts,
      Summary = summary
    });
    return ts;
  }

  private void ModelValidator_OnValidatingType(ModelValidator sender, ValidatingTypeInfo info)
  {
    ModelMonitor?.ShowPhaseProgress(PPS.ScanValidation, new ProgressInfo
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

  //protected TimeSpan RenameTypes()
  //{
  //  ModelMonitor?.ShowPhaseStart(TypeRename,"Renaming types");
  //  DateTime t1 = DateTime.Now;
  //  var renamedTypesCount = ModelManager.RenameSpecificTypes();
  //  foreach (var type in TypeManager.AllTypes.ToArray())
  //  {
  //    ModelManager.RenameType(type);
  //  }
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  ModelMonitor?.ShowPhaseEnd("Renaming types", new SummaryInfo
  //  {
  //    Time = ts,
  //    Summary = new Dictionary<string, object>{
  //      {"Renamed types", renamedTypesCount },
  //      }
  //  });
  //  return ts;
  //}

  //protected TimeSpan SetTypeConversions()
  //{
  //  ModelMonitor?.ShowPhaseStart("Converting types");
  //  DateTime t1 = DateTime.Now;
  //  var converterTypesCount = 0;
  //  foreach (var type in TypeManager.AllTypes.ToArray())
  //  {
  //    if (ModelManager.TryAddTypeConversion(type))
  //    {
  //      converterTypesCount++;
  //      ModelMonitor?.ShowPhaseProgress("Converting types", new ProgressInfo
  //      {
  //        PreStr = "checked",
  //        Done = checkedTypesCount,
  //        MidStr = "types",
  //        Summary = new Dictionary<string, object>{
  //      {"converted", converterTypesCount } },
  //        PostStr = $"{type.GetFullName()}"
  //      });
  //    }
  //  }
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  var convertedTypesCount = TypeManager.ConvertedTypes.Count();
  //  ModelMonitor?.ShowPhaseEnd("Converting types", new SummaryInfo
  //  {
  //    Time = ts,
  //    Summary = new Dictionary<string, object>{
  //      {"Converted types", convertedTypesCount },
  //      }
  //  });
  //  return ts;
  //}

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
  //    ModelMonitor?.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName()}");
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
}

