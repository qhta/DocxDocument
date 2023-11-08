namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PrinterSettingsReference Class.
/// </summary>
public partial class PrinterSettingsReference: ModelElement<DXW.PrinterSettingsReference>
{
  public PrinterSettingsReference(): base(){ }
  
  public PrinterSettingsReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrinterSettingsReference(DXW.PrinterSettingsReference openXmlElement): base(openXmlElement) { }
  
}
