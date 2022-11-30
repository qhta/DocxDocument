namespace DocumentModel.Spreadsheet;

/// <summary>
/// Color Scale.
/// </summary>
public interface IColorScale // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormatValueObject>? ConditionalFormatValueObjects { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IColorType>? Colors { get ; set; }
  
}
