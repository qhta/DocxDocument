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
  
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public GradientFillProperties? GradientFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
