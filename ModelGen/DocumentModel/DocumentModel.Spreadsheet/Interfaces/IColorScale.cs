namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColorScale Class.
/// </summary>
public interface IColorScale // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IColorType>? Colors { get ; set; }
  
}
