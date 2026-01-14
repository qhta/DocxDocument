namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the previous version of run properties, used in <see cref="RunPropertiesChange"/>.
/// This interface extends <see cref="ExtBaseRunProperties"/> and is used to store the state of run formatting before a tracked change, enabling comparison and revision management in WordprocessingML documents.
/// </summary>
public interface PreviousRunProperties : ExtBaseRunProperties
{
}