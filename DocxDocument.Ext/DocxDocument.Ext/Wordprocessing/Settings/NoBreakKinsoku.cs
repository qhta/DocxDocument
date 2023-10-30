using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the set of characters which shall be restricted from beginning or ending a line for runs of text 
/// which shall be subject to custom line breaking logic using the kinsoku element (§17.3.1.16) 
/// when the contents of the document are displayed. 
/// This constraint shall only apply to text which has been flagged in the language of this rule via the lang element (§17.3.2.20) 
/// or automatic detection methods outside the scope of /IEC 29500.
/// </summary>
public record NoBreakKinsoku: IOpenXmlElementMappedObject
{
  public NoBreakKinsoku()
  {
  }

  public NoBreakKinsoku(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXW.NoLineBreaksBeforeKinsoku noLineBreaksBeforeKinsoku)
    {    
      Lang = noLineBreaksBeforeKinsoku.Language;
      Val = noLineBreaksBeforeKinsoku.Val;
    }
    else
    if (openXmlElement is DXW.NoLineBreaksAfterKinsoku noLineBreaksAfterKinsoku)
    {
      Lang = noLineBreaksAfterKinsoku.Language;
      Val = noLineBreaksAfterKinsoku.Val;
    } 
    else
      throw new InvalidOperationException($"SourceElement must be of NoLineBreaksBeforeKinsoku or NoLineBreaksAfterKinsoku type");
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (typeof(OpenXmlElementType) == typeof(DXW.NoLineBreaksBeforeKinsoku))
    {    
      var openXmlElement = new DXW.NoLineBreaksBeforeKinsoku();
      openXmlElement.Language = Lang;
      openXmlElement.Val = Val;
      return (OpenXmlElementType)(DX.OpenXmlElement)openXmlElement;
    }
    else
    if (typeof(OpenXmlElementType) == typeof(DXW.NoLineBreaksAfterKinsoku))
    {    
      var openXmlElement = new DXW.NoLineBreaksAfterKinsoku();
      openXmlElement.Language = Lang;
      openXmlElement.Val = Val;
      return (OpenXmlElementType)(DX.OpenXmlElement)openXmlElement;
    }
    else
      throw new InvalidOperationException($"SourceElement must be of NoLineBreaksBeforeKinsoku or NoLineBreaksAfterKinsoku type");
  }

  [DataMember]
  public string? Lang { get; set; }
  [DataMember]
  public string? Val { get; set; }
}
