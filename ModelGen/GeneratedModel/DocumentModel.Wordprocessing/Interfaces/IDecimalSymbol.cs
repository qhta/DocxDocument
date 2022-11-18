namespace DocumentModel.Wordprocessing;

/// <summary>
/// Radix Point for Field Code Evaluation.
/// </summary>
public interface IDecimalSymbol // : DocumentFormat.OpenXml.Wordprocessing.StringType
{
  /// <summary>
  /// String Value
  /// </summary>
  public string? Val { get ; set; }
  
}
