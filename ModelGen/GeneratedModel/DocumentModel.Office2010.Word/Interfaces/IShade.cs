namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Shade Class.
/// </summary>
public interface IShade // : DocumentFormat.OpenXml.Office2010.Word.PositiveFixedPercentageType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Val { get ; set; }
  
}
