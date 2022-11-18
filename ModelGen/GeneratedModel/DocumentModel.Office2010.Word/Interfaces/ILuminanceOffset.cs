namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LuminanceOffset Class.
/// </summary>
public interface ILuminanceOffset // : DocumentFormat.OpenXml.Office2010.Word.PercentageType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Val { get ; set; }
  
}
