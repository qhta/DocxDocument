using DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public static class CommentExConverter
{
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public static Byte[]? GetParaId(CommentEx? openXmlElement)
  {
    if (openXmlElement?.ParaId?.Value != null)
      return Convert.FromHexString(openXmlElement.ParaId.Value);
    return null;
  }

  public static void SetParaId(CommentEx? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.ParaId = Convert.ToHexString(value);
      else
        openXmlElement.ParaId = null;
    }
  }

  /// <summary>
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public static Byte[]? GetParaIdParent(CommentEx? openXmlElement)
  {
    if (openXmlElement?.ParaIdParent?.Value != null)
      return Convert.FromHexString(openXmlElement.ParaIdParent.Value);
    return null;
  }

  public static void SetParaIdParent(CommentEx? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.ParaIdParent = Convert.ToHexString(value);
      else
        openXmlElement.ParaIdParent = null;
    }
  }

  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetDone(CommentEx? openXmlElement)
  {
    return openXmlElement?.Done?.Value;
  }

  public static void SetDone(CommentEx? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Done = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Done = null;
  }

  public static DocumentModel.Wordprocessing.CommentEx? CreateModelElement(CommentEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentEx();
      value.ParaId = GetParaId(openXmlElement);
      value.ParaIdParent = GetParaIdParent(openXmlElement);
      value.Done = GetDone(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentEx? value)
    where OpenXmlElementType : CommentEx, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParaId(openXmlElement, value?.ParaId);
      SetParaIdParent(openXmlElement, value?.ParaIdParent);
      SetDone(openXmlElement, value?.Done);
      return openXmlElement;
    }
    return default;
  }
}