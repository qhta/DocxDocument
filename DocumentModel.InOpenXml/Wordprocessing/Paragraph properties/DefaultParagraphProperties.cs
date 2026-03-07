namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the default paragraph properties for text formatting in a WordprocessingML document.
/// This class extends <see cref = "PreviousParagraphProperties"/> and is used in <see cref = "DocDefaults"/> to specify the default paragraph-level formatting applied to all paragraphs in the document unless overridden by more specific formatting.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphPropertiesDefault))]
public class DefaultParagraphProperties : BaseParagraphProperties<DXW.ParagraphPropertiesDefault>
{
}