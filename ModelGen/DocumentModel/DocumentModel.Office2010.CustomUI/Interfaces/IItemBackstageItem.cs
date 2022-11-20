namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the ItemBackstageItem Class.
/// </summary>
public interface IItemBackstageItem // : DocumentFormat.OpenXml.Office2010.CustomUI.BackstageItemType
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get ; set; }
  
}
