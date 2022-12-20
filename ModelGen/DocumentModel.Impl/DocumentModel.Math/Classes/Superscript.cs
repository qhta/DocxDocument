namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public partial class SuperscriptImpl: ModelElementImpl, Superscript
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.Superscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Superscript?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SuperscriptImpl(): base() {}
  
  public SuperscriptImpl(DocumentFormat.OpenXml.Math.Superscript openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public DocumentModel.Math.SuperscriptProperties? SuperscriptProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
        if (item != null)
          return new DocumentModel.Math.SuperscriptPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.SuperscriptPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
        if (item != null)
          return new DocumentModel.Math.BaseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.BaseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
        if (item != null)
          return new DocumentModel.Math.SuperArgumentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.SuperArgumentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
