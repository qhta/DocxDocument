namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public class MathFunctionImpl: ModelElementImpl, MathFunction
{
  public DocumentFormat.OpenXml.Math.MathFunction? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MathFunction?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MathFunctionImpl(): base() {}
  
  public MathFunctionImpl(DocumentFormat.OpenXml.Math.MathFunction openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Function Properties.
  /// </summary>
  public DocumentModel.Math.FunctionProperties? FunctionProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
        if (item != null)
          return new DocumentModel.Math.FunctionPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.FunctionPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public DocumentModel.Math.FunctionName? FunctionName
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionName>();
        if (item != null)
          return new DocumentModel.Math.FunctionNameImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionName>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.FunctionNameImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Base (Argument).
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
  
}
