namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public interface IDisplayUnits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Double? CustomDisplayUnit { get ; set; }
  
  public DocumentModel.Drawing.Charts.BuiltInUnitKind? BuiltInUnit { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDisplayUnitsLabel? DisplayUnitsLabel { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
