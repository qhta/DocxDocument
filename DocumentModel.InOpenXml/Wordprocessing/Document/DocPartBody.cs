namespace DocumentModel.Wordprocessing;
  /// <summary>
  /// Specifies the contents of the parent glossary document entry in a WordprocessingML document.
  /// This class extends <see cref="AbstractBody{T}"/> and consists of one or more block-level elements, analogous to the body element of the main document story, enabling advanced management and reuse of document parts such as building blocks and autotext entries.
  /// </summary>
  public class DocPartBody : AbstractBody<DXW.DocPartBody>
  {
  }