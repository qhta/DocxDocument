namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ColorScale Class.
/// </summary>
public interface IColorScale // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IColorType>? Colors { get ; set; }
  
}
