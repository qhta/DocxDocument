namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public partial class SubSuperscriptImpl: ModelElementImpl, SubSuperscript
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.SubSuperscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubSuperscript?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SubSuperscriptImpl(): base() {}
  
  public SubSuperscriptImpl(DocumentFormat.OpenXml.Math.SubSuperscript openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.SubSuperscriptProperties? SubSuperscriptProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
        if (item != null)
          return new DocumentModel.Math.SubSuperscriptPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.SubSuperscriptPropertiesImpl)?.OpenXmlElement;
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
  /// Subscript (Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
        if (item != null)
          return new DocumentModel.Math.SubArgumentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.SubArgumentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
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
