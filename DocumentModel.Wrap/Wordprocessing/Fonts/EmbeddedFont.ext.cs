namespace DocumentModel.Wordprocessing;

public partial class EmbeddedFont : ModelElement
{
  /// <summary>
  /// Retrieves the embedded font stored in the document.
  /// </summary>
  /// <returns></returns>
  public byte[]? GetEmbedFont()
  {
    if (Id!=null && ParentDocument!=null)
    {
      var embeddedFonts = ParentDocument.EmbeddedFonts;
      if (embeddedFonts != null && embeddedFonts.TryGetValue(Id, out var bytes)) 
        return bytes;
    }
    return null;
  }

  //void DeobfuscateFont(XpsFont font, string outname)
  //{
  //  using (Stream stm = font.GetStream())
  //  {
  //    using (FileStream fs = new FileStream(outname, FileMode.Create))
  //    {
  //      byte[] dta = new byte[stm.Length];
  //      stm.Read(dta, 0, dta.Length);
  //      if (font.IsObfuscated)
  //      {
  //        string guid = new Guid(font.Uri.GetFileName().Split('.')[0]).ToString("N");
  //        byte[] guidBytes = new byte[16];
  //        for (int i = 0; i < guidBytes.Length; i++)
  //          guidBytes[i] = Convert.ToByte(guid.Substring(i * 2, 2), 16);

  //        for (int i = 0; i < 32; i++)
  //        {
  //          int gi = guidBytes.Length - (i % guidBytes.Length) - 1;
  //          dta[i] ^= guidBytes[gi];
  //        }
  //      }
  //      fs.Write(dta, 0, dta.Length);
  //    }
  //  }
  //}
}
