namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public interface IStrDataExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public System.Boolean? AutoGeneneratedCategories { get ; set; }
  
}
