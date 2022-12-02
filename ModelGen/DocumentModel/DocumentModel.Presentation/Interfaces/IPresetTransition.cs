namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PresetTransition Class.
/// </summary>
public interface IPresetTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// prst, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Preset { get ; set; }
  
  /// <summary>
  /// invX, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? InvX { get ; set; }
  
  /// <summary>
  /// invY, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? InvY { get ; set; }
  
}
