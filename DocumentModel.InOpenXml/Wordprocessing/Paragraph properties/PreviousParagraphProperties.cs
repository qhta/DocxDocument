namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the previous version of paragraph properties, used in <see cref="ParagraphPropertiesChange"/>.
 /// This interface extends <see cref="ExtBaseParagraphProperties"/> and is used to store the state of paragraph formatting before a tracked change, enabling comparison and revision management in WordprocessingML documents.
/// </summary>
public class PreviousParagraphProperties : ExtBaseParagraphProperties
{
}