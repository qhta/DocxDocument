namespace DocumentModel.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public partial class FractionImpl: ModelElementImpl, Fraction
{
  public DocumentFormat.OpenXml.Math.Fraction? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Fraction?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FractionImpl(): base() {}
  
  public FractionImpl(DocumentFormat.OpenXml.Math.Fraction openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  public DocumentModel.Math.FractionProperties? FractionProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionProperties>();
        if (item != null)
          return new DocumentModel.Math.FractionPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.FractionPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  public DocumentModel.Math.Numerator? Numerator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Numerator>();
        if (item != null)
          return new DocumentModel.Math.NumeratorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Numerator>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.NumeratorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  public DocumentModel.Math.Denominator? Denominator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Denominator>();
        if (item != null)
          return new DocumentModel.Math.DenominatorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Denominator>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.DenominatorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
