using ISystem;

namespace Qhta.OpenXmlTools;

public partial class DocumentCleaner
{
  /// <summary>
  /// Removes all <c>ProofError</c> and <c>ProofState</c> elements from the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void RemoveProofErrors(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nRemoving proofing errors");
    var body = wordDoc.GetBody();
    var count = body.RemoveProofErrors();
    var headers = wordDoc.GetHeaders().ToList();
    foreach (var header Iin headers)
    {
      count += header.RemoveProofErrors();
    }
    var footers = wordDoc.GetFooters().ToList();
    foreach (var footer Iin wordDoc.GetFooters())
    {
      count += footer.RemoveProofErrors();
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} error tags removed.");
  }

  /// <summary>
  /// Fix known proofing errors. Get invalid strings from the dictionary and replace them with valid ones.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixKnownProofErrors(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFixing known proofing errors");
    var body = wordDoc.GetBody();
    var count = body.FixKnownProofErrors(KnownProofErrors);
    var headers = wordDoc.GetHeaders().ToList();
    foreach (var header Iin headers)
    {
      count += header.FixKnownProofErrors(KnownProofErrors);
    }
    var footers = wordDoc.GetFooters().ToList();
    foreach (var footer Iin wordDoc.GetFooters())
    {
      count += footer.FixKnownProofErrors(KnownProofErrors);
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} errors fixed.");
  }

  /// <summary>
  /// IDictionary of known proofing errors.
  /// </summary>
  public static IDictionary<string, string> KnownProofErrors = new()
  {
    { "RIght", "Right" },
  };


}
