namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Indentation Class.
/// </summary>
public class IndentationImpl: ModelElementImpl, Indentation
{
  public DocumentFormat.OpenXml.Wordprocessing.Indentation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Indentation?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Left Indentation
  /// </summary>
  public String? Left
  {
    get => (String?)OpenXmlElement?.Left?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Left = (System.String?)value;
    }
  }
  
  /// <summary>
  /// start, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Start
  {
    get => (String?)OpenXmlElement?.Start?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Start = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Left Indentation in Character Units
  /// </summary>
  public Int32? LeftChars
  {
    get => (Int32?)OpenXmlElement?.LeftChars?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LeftChars = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// startChars, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StartCharacters
  {
    get => (Int32?)OpenXmlElement?.StartCharacters?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartCharacters = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Right Indentation
  /// </summary>
  public String? Right
  {
    get => (String?)OpenXmlElement?.Right?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Right = (System.String?)value;
    }
  }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  public String? End
  {
    get => (String?)OpenXmlElement?.End?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.End = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Right Indentation in Character Units
  /// </summary>
  public Int32? RightChars
  {
    get => (Int32?)OpenXmlElement?.RightChars?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightChars = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// endChars, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? EndCharacters
  {
    get => (Int32?)OpenXmlElement?.EndCharacters?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndCharacters = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Indentation Removed from First Line
  /// </summary>
  public String? Hanging
  {
    get => (String?)OpenXmlElement?.Hanging?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hanging = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Indentation Removed From First Line in Character Units
  /// </summary>
  public Int32? HangingChars
  {
    get => (Int32?)OpenXmlElement?.HangingChars?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HangingChars = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Additional First Line Indentation
  /// </summary>
  public String? FirstLine
  {
    get => (String?)OpenXmlElement?.FirstLine?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstLine = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Additional First Line Indentation in Character Units
  /// </summary>
  public Int32? FirstLineChars
  {
    get => (Int32?)OpenXmlElement?.FirstLineChars?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstLineChars = (System.Int32?)value;
    }
  }
  
}
