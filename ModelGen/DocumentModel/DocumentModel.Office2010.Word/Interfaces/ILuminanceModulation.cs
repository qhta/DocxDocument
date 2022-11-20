namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LuminanceModulation Class.
/// </summary>
public interface ILuminanceModulation // : DocumentFormat.OpenXml.Office2010.Word.PercentageType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Val { get ; set; }
  
}
