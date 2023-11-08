namespace ModelGen;

/// <summary>
/// Represents stored options for process of model generation.
/// </summary>
public record ProcessOptions
{

  /// <summary>
  /// Specifies the name of the subfolder of user's AppData containing config files for input and produced log files .
  /// </summary>
  public string? AppDataFolder { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies the name of the generator class.
  /// </summary>
  public string? GeneratorType { [DebuggerStepThrough] get; set; }
  
  /// <summary>
  /// Specifies a path for the generated code.
  /// </summary>
  public string? CodeOutputPath { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies the name of the generated C# project.
  /// </summary>
  public string? ProjectName { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies the name of the generated C# solution.
  /// </summary>
  public string? SolutionName { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies the name of the generated C# namespace root.
  /// </summary>
  public string? RootNamespace { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies the name of type used as a root for scan types phase.
  /// </summary>
  public string? ScanTypeName { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies a name of model doc file. It must contain XML-serialized ModelDoc.
  /// </summary>
  public string? ModelDocFileName { [DebuggerStepThrough] get; set; }
  
  /// <summary>
  /// Specifies how many phases of process to run.
  /// </summary>
  public int StopAtPhase { [DebuggerStepThrough] get; set; } = 1;

  /// <summary>
  /// Specifies whether results of the scan source phase should be validated.
  /// </summary>
  public bool ValidateScan { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies whether results of the add docs phase should be validated.
  /// </summary>
  public bool ValidateDocs { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies whether results of the rename phase should be validated.
  /// </summary>
  public bool ValidateNames { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies whether results of the conversion phase should be validated.
  /// </summary>
  public bool ValidateConversion { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies whether results of the fixage phase should be validated.
  /// </summary>
  public bool ValidateFix { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies whether results of the code generation phase should be validated.
  /// </summary>
  public bool ValidateGeneration { [DebuggerStepThrough] get; set; }

  ///// <summary>
  ///// Selection of data displayed in console application of ModelGenRun.
  ///// </summary>
  //public MDS Display { [DebuggerStepThrough] get; set; }

  ///// <summary>
  ///// Specifies which data should be displayed in console application of ModelGenRun.
  ///// </summary>
  //public DisplayOptions? DisplayOptions { [DebuggerStepThrough] get; set; }


}
