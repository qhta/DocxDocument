namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the RippleTransition Class.
/// </summary>
public interface IRippleTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Direction { get ; set; }
  
}
