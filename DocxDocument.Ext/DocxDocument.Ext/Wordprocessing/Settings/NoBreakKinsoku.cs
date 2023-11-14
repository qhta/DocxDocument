using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of characters which shall be restricted from beginning or ending a line for runs of text 
/// which shall be subject to custom line breaking logic using the kinsoku element (§17.3.1.16) 
/// when the contents of the document are displayed. 
/// This constraint shall only apply to text which has been flagged in the language of this rule via the lang element (§17.3.2.20) 
/// or automatic detection methods outside the scope of /IEC 29500.
/// </summary>
[DataContract]
public class NoBreakKinsoku : ModelElement, IOpenXmlElementMappedObject
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public NoBreakKinsoku() { }

  public NoBreakKinsoku(DX.OpenXmlElement openXmlElement)
  {
    _Element = openXmlElement;
    if (openXmlElement is DXW.NoLineBreaksBeforeKinsoku noLineBreaksBeforeKinsoku)
    {
      _Lang = noLineBreaksBeforeKinsoku.Language;
      _Val = noLineBreaksBeforeKinsoku.Val;
    }
    else
    if (openXmlElement is DXW.NoLineBreaksAfterKinsoku noLineBreaksAfterKinsoku)
    {
      _Lang = noLineBreaksAfterKinsoku.Language;
      _Val = noLineBreaksAfterKinsoku.Val;
    }
    else
      throw new InvalidOperationException($"SourceElement must be either of NoLineBreaksBeforeKinsoku or NoLineBreaksAfterKinsoku type");
  }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Gets a specific OpenXmlElement for the value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType result)
      return result;
    if (typeof(OpenXmlElementType) == typeof(DXW.NoLineBreaksBeforeKinsoku))
    {
      var openXmlElement = new DXW.NoLineBreaksBeforeKinsoku();
      openXmlElement.Language = Lang;
      openXmlElement.Val = Val;
      return (OpenXmlElementType)(DX.OpenXmlElement)openXmlElement;
    }
    else
    if (typeof(OpenXmlElementType) == typeof(DXW.NoLineBreaksAfterKinsoku))
    {
      var openXmlElement = new DXW.NoLineBreaksAfterKinsoku();
      openXmlElement.Language = Lang;
      openXmlElement.Val = Val;
      return (OpenXmlElementType)(DX.OpenXmlElement)openXmlElement;
    }
    else
      throw new InvalidOperationException($"Element type {typeof(OpenXmlElementType)} not supported");
  }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  internal DX.OpenXmlElement? _Element { get; private set; }

  /// <summary>
  /// Specifies the language of text for which the parent custom line breaking rule shall be applied. 
  /// Applications supporting this functionality shall support custom line breaking for the following four languages:
  /// <list type="bullet">
  ///   <item>Chinese (Traditional)</item>
  ///   <item>Chinese (Simplified)</item>
  ///   <item>Japanese</item>
  ///   <item>Korean</item>
  /// </list>
  /// </summary>
  [DataMember]
  public string? Lang
  {
    get => _Lang;
    set
    {
      if (_Lang != value)
      {
        _Lang = value;
        if (_Element != null)
        {
          var langProperty = _Element.GetType().GetProperty("Language");
          langProperty?.SetValue(_Element, value);
        }
      }
    }
  }
  private string? _Lang;

  /// <summary>
  /// Specifies the set of characters which shall be included in the custom line breaking rule.
  /// </summary>
  [DataMember]
  public string? Val
  {
    get => _Val;
    set
    {
      if (_Val != value)
      {
        _Val = value;
        if (_Element != null)
        {
          var valProperty = _Element.GetType().GetProperty("Val");
          valProperty?.SetValue(_Element, value);
        }
      }
    }
  }
  private string? _Val;
}
