namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextDirectionValues enumeration.
/// </summary>
public partial class TextDirectionValues: ModelElement<DXW.TextDirectionValues>
{
  public TextDirectionValues(): base(){ }
  
  public TextDirectionValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextDirectionValues(DXW.TextDirectionValues openXmlElement): base(openXmlElement) { }
  
}
