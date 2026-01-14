namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents run properties that are declared within a style definition in a WordprocessingML document.
/// This interface extends <see cref="ExtBaseRunProperties"/> and is used to specify character-level formatting that is applied through styles, enabling consistent and reusable text formatting across the document.
/// </summary>
public interface StyleRunProperties : ExtBaseRunProperties
{
}