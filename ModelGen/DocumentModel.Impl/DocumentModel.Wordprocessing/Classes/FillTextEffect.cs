namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public class FillTextEffectImpl: ModelElementImpl, FillTextEffect
{
  public DocumentFormat.OpenXml.Office2010.Word.FillTextEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.FillTextEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FillTextEffectImpl(): base() {}
  
  public FillTextEffectImpl(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SolidColorFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SolidColorFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.GradientFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.GradientFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
