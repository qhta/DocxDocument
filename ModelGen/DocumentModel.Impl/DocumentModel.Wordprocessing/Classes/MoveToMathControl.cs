namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public class MoveToMathControlImpl: DocumentModel.Wordprocessing.MathControlMoveTypeImpl, MoveToMathControl
{
  public new DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MoveToMathControlImpl(): base() {}
  
  public MoveToMathControlImpl(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.RunProperties? RunProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RunPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RunPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
        if (item != null)
          return new DocumentModel.Wordprocessing.InsertedMathControlImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.InsertedMathControlImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DeletedMathControlImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DeletedMathControlImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
