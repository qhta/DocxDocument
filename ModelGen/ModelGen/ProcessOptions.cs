namespace ModelGen;

/// <summary>
/// Represents stored options for process of model generation.
/// </summary>
public record ProcessOptions
{
  /// <summary>
  /// Specifies how many phases of process to run.
  /// </summary>
  public int StopAtPhase { get; set; } = 1;

  /// <summary>
  /// Specifies whether results of the scan source phase should be validated.
  /// </summary>
  public bool ValidateScan { get; set; }

  /// <summary>
  /// Specifies whether results of the add docs phase should be validated.
  /// </summary>
  public bool ValidateDocs { get; set; }

  /// <summary>
  /// Specifies whether results of the rename phase should be validated.
  /// </summary>
  public bool ValidateNames { get; set; }

  /// <summary>
  /// Specifies whether results of the conversion phase should be validated.
  /// </summary>
  public bool ValidateConversion { get; set; }


  /// <summary>
  /// Specifies whether results of the fixage phase should be validated.
  /// </summary>
  public bool ValidateFix { get; set; }

  /// <summary>
  /// Specifies whether results of the code generation phase should be validated.
  /// </summary>
  public bool ValidateGeneration { get; set; }

  /// <summary>
  /// Specifies the name of type used as a root for scan types phase.
  /// </summary>
  public string ScanTypeName { get; set; } = "DocumentFormat.OpenXml.Packaging.WordprocessingDocument";

  /// <summary>
  /// Specifies a name of model doc file. It must contain XML-serialized ModelDoc.
  /// </summary>
  public string ModelDocFileName { get; set; } = @"c:\Users\qhta1\AppData\Roaming\ModelGen\ModelDoc.xml";

  /// <summary>
  /// Specifies a path for the generated model code.
  /// </summary>
  public string ModelCodeOutputPath { get; set; } = @"DocumentModel";

  ///// <summary>
  ///// Selection of data displayed in console application of ModelGenRun.
  ///// </summary>
  //public MDS Display { get; set; }

  ///// <summary>
  ///// Specifies which data should be displayed in console application of ModelGenRun.
  ///// </summary>
  //public DisplayOptions? DisplayOptions { get; set; }


}
