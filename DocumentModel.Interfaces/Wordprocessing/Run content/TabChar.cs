namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tab character in a text run
/// An tab is a character which is used to advance the position on the current line of text, using the following logic:
/// <list type="bullet">
/// <item>
/// When there are one or more custom tab stops defined using the tabs element, 
/// then the tab character shall advance to the next custom tab stop location 
/// which is further along than the starting location of the tab.
/// </item>
/// <item>
/// When there are no custom tab stops which are further than the current position in the line, 
/// the tab character shall advance to the nearest multiple of the defaultTabStop element width value.
/// </item>
/// </list>
/// </summary>
public class TabChar: ModelElement, IRunContent
{
}