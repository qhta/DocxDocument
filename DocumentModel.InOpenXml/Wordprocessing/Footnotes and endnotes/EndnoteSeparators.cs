namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of endnote separator references in a WordprocessingML document.
/// This class provides access to and management of <see cref="EndnoteSeparator"/> objects, enabling advanced organization and referencing of endnote separators for visual separation and formatting of endnote content.
/// </summary>
public class EndnoteSeparators: ElementCollection<EndnoteSeparator>
{
  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}