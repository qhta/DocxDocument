using DocumentFormat.OpenXml.Math;

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

  public void RunOn(Type type, MDS monitorDisplaySelector = MDS.None, DisplayOptions? displayOptions = null)
  {
    IsRun = true;
    if (displayOptions == null)
      displayOptions = new DisplayOptions();
    if (ModelMonitor!=null)
    {
      TypeReflector.OnReflection += TypeReflector_OnReflection;
    }
    SourceAssembly = type.Assembly;
    TimeSpan totalTime = TimeSpan.Zero;
    totalTime += ScanType(type);

    if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
      ModelMonitor?.ShowNamespaceSummary(NTS.Origin);

    if (monitorDisplaySelector.HasFlag(MDS.ScannedTypes))
      ModelMonitor?.ShowNamespacesDetails(displayOptions with { NamespaceTypeSelector = NTS.Origin});

    //totalTime += RenameTypes();
    //if (monitorDisplaySelector.HasFlag(MDS.TypeRenames))
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

    ModelMonitor?.ShowProcessSummary(new ProcessInfo{ TotalTime = totalTime });
    IsRun = false;
  }

  private void TypeReflector_OnReflection(ReflectionInfo info)
  {
    ModelMonitor?.WriteSameLine(
        $"Total {TypeManager.TotalTypesCount} registered types, {info.Done} reflected, {info.Waiting} waiting. {info.Current?.OriginalNamespace}.{info.Current?.OriginalName}");

  }

  #region Processing methods
  protected TimeSpan ScanType(Type type)
  {
    ModelMonitor?.WriteLine("Scanning types");
    DateTime t1 = DateTime.Now;
    ModelManager.TryAcceptType(type, out var typeInfo);
    TypeReflector.WaitDone();
    ModelMonitor?.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.WriteLine($"Scanning time is {ts}");
    var allTypesCount = TypeManager.AllTypes.Count();
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).ToArray().Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    ModelMonitor?.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    ModelMonitor?.WriteLine($"Accepted {acceptedTypesCount} types");
    return ts;
  }

  protected TimeSpan RenameTypes()
  {
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine("Renaming types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    var renamedCount = ModelManager.RenameSpecificTypes();
    foreach (var type in TypeManager.AllTypes.ToArray())
    {
      ModelMonitor?.WriteSameLine($"Checked {++checkedCount} types. {type.GetFullName()}");
      if (ModelManager.RenameType(type))
        renamedCount++;
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine($"Renaming time is {ts}");
    ModelMonitor?.WriteLine($"Renamed {renamedCount} types");
    return ts;
  }

  protected TimeSpan SetTypeConversions()
  {
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine("Converting types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    foreach (var type in TypeManager.AllTypes.ToArray())
    {
      checkedCount++;
      ModelMonitor?.WriteSameLine($"Checked {checkedCount} types. {type.GetFullName()}");
      ModelManager.TryAddTypeConversion(type);
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine($"Converting time is {ts}");
    var convertedTypesCount = TypeManager.ConvertedTypes.Count();
    ModelMonitor?.WriteLine($"Converted {convertedTypesCount} types");
    ModelMonitor?.ShowTypeConversions();
    return ts;
  }

  protected TimeSpan CheckTypeUsage()
  {
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine("Checking type usage");
    DateTime t1 = DateTime.Now;
    var checkCount = 0;
    foreach (var type in TypeManager.AcceptedTypes.ToArray())
    {
      ModelManager.CheckTypeUsage(type,
        (item) => { ModelMonitor?.WriteSameLine($"Checked {++checkCount} types. {item.GetFullName()}"); });
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var usedCount = TypeManager.UsedTypes.Count();
    var acceptedCount = TypeManager.AcceptedTypes.Count();
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine($"Checking time is {ts}");
    ModelMonitor?.WriteLine($"Found {usedCount} used types, {acceptedCount} accepted types");
    //ModelMonitor?.ShowUnusedTypes();
    return ts;
  }


  protected TimeSpan ValidateTypes()
  {
    ModelMonitor?.WriteLine();
    ModelMonitor?.WriteLine("Validating types & namespaces");
    DateTime t1 = DateTime.Now;
    var checkedTypesCount = 0;
    var checkedNamespacesCount = 0;
    var invalidTypesCount = 0;
    foreach (var typeInfo in TypeManager.AllTypes.ToArray())
    {
      ModelMonitor?.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName()}");
      if (!ModelManager.ValidateType(typeInfo))
        invalidTypesCount++;
    }
    //invalidTypesCount += ModelManager.CheckNamespacesDuplicatedTypesAsync((int repaired, int waiting)
    //  =>
    //  ModelMonitor?.WriteSameLine($"Repaired {repaired} types. Waiting for {waiting} namespaces ")
    //  );
    foreach (var nspace in TypeManager.GetNamespaces(NTS.Target))
    {
      ModelMonitor?.WriteSameLine($"Checked {++checkedNamespacesCount} namespaces for duplicate type names. {nspace}");
      int n = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
      if (n > 0)
        invalidTypesCount += n;
    }
    ModelMonitor?.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelMonitor?.WriteLine($"Validation time is {ts}");
    ModelMonitor?.WriteLine($"Invalid {invalidTypesCount} types found and repaired");
    return ts;
  }

  protected abstract TimeSpan GenerateCode();
  #endregion

}

