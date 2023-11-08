namespace ModelGen;

/// <summary>
/// Helper class to write documentation comments divided into lines according to xElement structure.
/// </summary>
public class DocumentationWriter
{
  /// <summary>
  /// Initialization constructor
  /// </summary>
  /// <param name="writer">.</param>
  /// <param name="lineIndent">Start line indent to subtract from lineWrapLimit.</param>
  /// <param name="lineWrapLimit">Maximum length of line to wrap text. If 0 then .ext is not wrapped.</param>
  public DocumentationWriter(TextWriter writer, int lineIndent, int lineWrapLimit)
  {
    Writer = writer;
    LineIndent = lineIndent;
    LineWrapLimit = lineWrapLimit;
  }

  /// <summary>
  /// Text writer to write lines of text
  /// </summary>
  public TextWriter Writer { [DebuggerStepThrough] get; }

  /// <summary>
  /// Start line indent to subtract from lineWrapLimit.
  /// </summary>
  public int LineIndent { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Maximum length of line to wrap text. If 0 then .ext is not wrapped.
  /// </summary>
  public int LineWrapLimit { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Writes documentation element with starting indent
  /// </summary>
  /// <param name="xElement">XElement of the documentation (e.g. "summary", "para")</param>
  /// <param name="indent">Indent after starting "/// ". Double spaces are inserted.</param>
  public void Write(XElement xElement, int indent = 0)
  {
    var indentStr = new String(' ', indent * 2);
    var header = xElement.Name.ToString();
    foreach (var attribute in xElement.Attributes())
    {
      header += $" {attribute.Name}=\"{attribute.Value}\"";
    }
    string? text = null;
    if (!xElement.HasElements)
    {
      text = xElement.Value.Trim();
      text = Qhta.HtmlUtils.HtmlTextUtils.EncodeHtmlEntities(text);
      if (text == "")
      {
        Writer.WriteLine($"/// {indentStr}<{header}/>");
        return;
      }
      else if (header == "c" || header == "remark")
      {
        Writer.WriteLine($"/// {indentStr}<{header}>{text}</{xElement.Name}>");
        return;
      }
    }

    Writer.WriteLine($"/// {indentStr}<{header}>");
    if (xElement.HasElements)
    {
      foreach (var subElement in xElement.Elements())
        Write(subElement, indent + 1);
    }
    else if (text != null)
    {
      var ss = text.Split('\n');
      foreach (var str in ss)
      {
        if (LineWrapLimit > 0)
        {
          var wrapLimit = LineWrapLimit - LineIndent - 4; // 4 = "/// ".Length;
          List<string> lines = Snork.TextWrap.TextWrapper.Wrap(str, wrapLimit);
          foreach (var line in lines)
            Writer.WriteLine($"/// {indentStr + "  "}{line}");
        }
        else
          Writer.WriteLine($"/// {indentStr + "  "}{str}");
      }
    }
    Writer.WriteLine($"/// {indentStr}</{xElement.Name}>");
  }
}
