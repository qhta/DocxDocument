namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public interface IDateAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDateAxExtension>? DateAxExtensions { get ; set; }
  
}
