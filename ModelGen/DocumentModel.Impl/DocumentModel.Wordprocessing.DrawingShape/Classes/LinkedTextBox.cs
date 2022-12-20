namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the LinkedTextBox Class.
/// </summary>
public partial class LinkedTextBoxImpl: ModelElementImpl, LinkedTextBox
{
  public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LinkedTextBoxImpl(): base() {}
  
  public LinkedTextBoxImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Id
  {
    get => (System.UInt16?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt16?)value;
    }
  }
  
  /// <summary>
  /// seq, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Sequence
  {
    get => (System.UInt16?)OpenXmlElement?.Sequence?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Sequence = (System.UInt16?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
