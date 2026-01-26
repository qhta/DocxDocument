namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of custom tab stop elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "TabStop"/> objects, enabling advanced control over tab alignment, leader characters, and tab stop positions within paragraphs.
/// </summary>
[OpenXmlType(typeof(TabStop))]
public class Tabs : ModelElementCollection<TabStop, DXW.Tabs, DXW.TabStop>
{
}