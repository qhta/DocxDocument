using System;
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

  public BaseCreator(string projectName, string outputPath)
  {
    ProjectName = projectName;
    OutputPath = outputPath;
  }

  public void RunOn(Type type, MDS monitorDisplaySelector = MDS.None, OTS? originTargetSelector = null,ShowOptions? showOptions = null)
  {
    SourceAssembly = type.Assembly;
    TimeSpan totalTime = TimeSpan.Zero;
    totalTime += ScanType(type);
    
    if (monitorDisplaySelector.HasFlag(MDS.ScannedNamespaces))
      ModelDisplay.ShowNamespaceSummary(originTargetSelector ?? OTS.Origin);

    totalTime += RenameTypes();
    if (monitorDisplaySelector.HasFlag(MDS.TypeRenames))
      ModelDisplay.ShowTypeRenames();
    

    totalTime += SetTypeConversions();
    if (monitorDisplaySelector.HasFlag(MDS.TypeConversions))
      ModelDisplay.ShowTypeConversions();

    totalTime += CheckTypeUsage();
    if (monitorDisplaySelector.HasFlag(MDS.TypeUsage))
      ModelDisplay.ShowNamespaceDetails(originTargetSelector ?? OTS.Target, showOptions ?? ShowOptions.BaseTypes | ShowOptions.Properties);

    totalTime += ValidateTypes();
    if (monitorDisplaySelector.HasFlag(MDS.ValidatedTypes))
      ModelDisplay.ShowNamespaceDetails(originTargetSelector ?? OTS.Target, showOptions ?? ShowOptions.BaseTypes | ShowOptions.Properties);

    totalTime += GenerateCode();

    ModelDisplay.WriteLine($"Total time = {totalTime}");
  }

  #region Processing methods
  protected TimeSpan ScanType(Type type)
  {
    ModelDisplay.WriteLine("Scanning types");
    DateTime t1 = DateTime.Now;
    var foundTypesCount = 0;
    var approvedTypesCount = 0;
    //if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? "")
    //                                            || ModelData.IncludedTypes.Contains(type.Name))
    {
      foundTypesCount++;
      if (ModelManager.TryAcceptType(type, out var typeInfo))
      {
        approvedTypesCount++;
      }
    }
    TypeReflector.WaitDone();
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Scanning time is {ts}");
    ModelDisplay.WriteLine($"Directly {foundTypesCount} types found, {approvedTypesCount} approved");
    var allTypesCount = TypeManager.AllTypes.Count();
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).ToArray().Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    ModelDisplay.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    ModelDisplay.WriteLine($"Accepted {acceptedTypesCount} types");
    return ts;
  }

  protected TimeSpan RenameTypes()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Renaming types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    var renamedCount = ModelManager.RenameSpecificTypes();
    foreach (var type in TypeManager.AllTypes.ToArray())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedCount} types. {type.GetFullName()}");
      if (ModelManager.RenameType(type))
        renamedCount++;
    }
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Renaming time is {ts}");
    ModelDisplay.WriteLine($"Renamed {renamedCount} types");
    return ts;
  }

  protected TimeSpan SetTypeConversions()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Converting types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    foreach (var type in TypeManager.AllTypes.ToArray())
    {
      checkedCount++;
      ModelDisplay.WriteSameLine($"Checked {checkedCount} types. {type.GetFullName()}");
      ModelManager.TryAddTypeConversion(type);
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Converting time is {ts}");
    var convertedTypesCount = TypeManager.ConvertedTypes.Count();
    ModelDisplay.WriteLine($"Converted {convertedTypesCount} types");
    //ModelDisplay.ShowTypeConversions();
    return ts;
  }

  protected TimeSpan CheckTypeUsage()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Checking type usage");
    DateTime t1 = DateTime.Now;
    var checkCount = 0;
    foreach (var type in TypeManager.AcceptedTypes.ToArray())
    {
      ModelManager.CheckTypeUsage(type,
        (item) => { ModelDisplay.WriteSameLine($"Checked {++checkCount} types. {item.GetFullName()}"); });
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var usedCount = TypeManager.UsedTypes.Count();
    var acceptedCount = TypeManager.AcceptedTypes.Count();
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Checking time is {ts}");
    ModelDisplay.WriteLine($"Found {usedCount} used types, {acceptedCount} accepted types");
    //ModelMonitorDisplay.ShowUnusedTypes();
    return ts;
  }

  
  protected TimeSpan ValidateTypes()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Validating types & namespaces");
    DateTime t1 = DateTime.Now;
    var checkedTypesCount = 0;
    var checkedNamespacesCount = 0;
    var invalidTypesCount = 0;
    foreach (var typeInfo in TypeManager.AllTypes.ToArray())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName()}");
      if (!ModelManager.ValidateType(typeInfo))
        invalidTypesCount++;
    }
    //invalidTypesCount += ModelManager.CheckNamespacesDuplicatedTypesAsync((int repaired, int waiting)
    //  =>
    //  ModelDisplay.WriteSameLine($"Repaired {repaired} types. Waiting for {waiting} namespaces ")
    //  );
    foreach (var nspace in TypeManager.GetNamespaces(OTS.Target))
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedNamespacesCount} namespaces for duplicate type names. {nspace}");
      int n = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
      if (n > 0)
        invalidTypesCount += n;
    }
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Validation time is {ts}");
    ModelDisplay.WriteLine($"Invalid {invalidTypesCount} types found and repaired");
    return ts;
  }

  protected abstract TimeSpan GenerateCode();
  #endregion

}

