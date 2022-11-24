namespace DocumentModel.Drawing;

/// <summary>
/// Scheme Color.
/// </summary>
public interface ISchemeColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public SchemeColorValues? Val { get ; set; }
  
}
