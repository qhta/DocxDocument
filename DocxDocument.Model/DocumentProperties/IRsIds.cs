namespace DocxDocument.Model;

public interface IRsIds: ICollection<HexInt>
{
  public HexInt? RsidRoot { get; set;}
}