namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public interface IStrDataExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public Boolean? AutoGeneneratedCategories { get ; set; }
  
}
