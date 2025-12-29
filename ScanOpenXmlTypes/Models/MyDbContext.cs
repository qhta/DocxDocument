using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abbreviation> Abbreviations { get; set; }

    public virtual DbSet<AbbreviationCategory> AbbreviationCategories { get; set; }

    public virtual DbSet<Agl> Agls { get; set; }

    public virtual DbSet<AglDuplikaty> AglDuplikaties { get; set; }

    public virtual DbSet<Alias> Aliases { get; set; }

    public virtual DbSet<AliasType> AliasTypes { get; set; }

    public virtual DbSet<Amsfont> Amsfonts { get; set; }

    public virtual DbSet<Amssymb> Amssymbs { get; set; }

    public virtual DbSet<Bidirectional> Bidirectionals { get; set; }

    public virtual DbSet<BlockCategory> BlockCategories { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CharName> CharNames { get; set; }

    public virtual DbSet<Charset0> Charset0s { get; set; }

    public virtual DbSet<Charset162> Charset162s { get; set; }

    public virtual DbSet<Charset186> Charset186s { get; set; }

    public virtual DbSet<Charset204> Charset204s { get; set; }

    public virtual DbSet<Charset238> Charset238s { get; set; }

    public virtual DbSet<Combination> Combinations { get; set; }

    public virtual DbSet<CombiningCharName> CombiningCharNames { get; set; }

    public virtual DbSet<ControlChar> ControlChars { get; set; }

    public virtual DbSet<CopyOfCharName> CopyOfCharNames { get; set; }

    public virtual DbSet<Eufrak> Eufraks { get; set; }

    public virtual DbSet<HtmlEntity> HtmlEntities { get; set; }

    public virtual DbSet<LaTeX> LaTeXes { get; set; }

    public virtual DbSet<LangScript> LangScripts { get; set; }

    public virtual DbSet<Languages1> Languages1s { get; set; }

    public virtual DbSet<LatexMath> LatexMaths { get; set; }

    public virtual DbSet<LatexMathT1> LatexMathT1s { get; set; }

    public virtual DbSet<LatexOt1> LatexOt1s { get; set; }

    public virtual DbSet<LatexT1> LatexT1s { get; set; }

    public virtual DbSet<Latexsym> Latexsyms { get; set; }

    public virtual DbSet<Latin1> Latin1s { get; set; }

    public virtual DbSet<Letter> Letters { get; set; }

    public virtual DbSet<Math1> Math1s { get; set; }

    public virtual DbSet<Math3> Math3s { get; set; }

    public virtual DbSet<Math5> Math5s { get; set; }

    public virtual DbSet<Mathcal> Mathcals { get; set; }

    public virtual DbSet<MtExtra> MtExtras { get; set; }

    public virtual DbSet<PasteError> PasteErrors { get; set; }

    public virtual DbSet<RomanNumber> RomanNumbers { get; set; }

    public virtual DbSet<RtcharName> RtcharNames { get; set; }

    public virtual DbSet<RtcontrolWord> RtcontrolWords { get; set; }

    public virtual DbSet<RtcontrolWordCategory> RtcontrolWordCategories { get; set; }

    public virtual DbSet<Rtf> Rtfs { get; set; }

    public virtual DbSet<Save> Saves { get; set; }

    public virtual DbSet<ScriptsAndNotation> ScriptsAndNotations { get; set; }

    public virtual DbSet<StandardName> StandardNames { get; set; }

    public virtual DbSet<StandardoweNazwy> StandardoweNazwies { get; set; }

    public virtual DbSet<StdName> StdNames { get; set; }

    public virtual DbSet<Stmaryrd> Stmaryrds { get; set; }

    public virtual DbSet<Symbol> Symbols { get; set; }

    public virtual DbSet<SymbolSet> SymbolSets { get; set; }

    public virtual DbSet<Symbole> Symboles { get; set; }

    public virtual DbSet<Textcomp> Textcomps { get; set; }

    public virtual DbSet<Uc> Ucs { get; set; }

    public virtual DbSet<UcdBlock> UcdBlocks { get; set; }

    public virtual DbSet<UcdBlockWritingSystem> UcdBlockWritingSystems { get; set; }

    public virtual DbSet<UcdRange> UcdRanges { get; set; }

    public virtual DbSet<UcdRangesStartEnd> UcdRangesStartEnds { get; set; }

    public virtual DbSet<UnicodeData13> UnicodeData13s { get; set; }

    public virtual DbSet<UnicodeDatum> UnicodeData { get; set; }

    public virtual DbSet<Webding> Webdings { get; set; }

    public virtual DbSet<Wingding> Wingdings { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<WritingSystem> WritingSystems { get; set; }

    public virtual DbSet<WritingSystemKind> WritingSystemKinds { get; set; }

    public virtual DbSet<WritingSystemType> WritingSystemTypes { get; set; }

    public virtual DbSet<Zapfdingbat> Zapfdingbats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\\\\\\\\Dane\\\\\\\\Unicode2.accdb;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abbreviation>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PrimaryKey");

            entity.HasIndex(e => new { e.Abbr, e.Ext }, "Abbr").IsUnique();

            entity.HasIndex(e => e.AbbrCat, "Ctg");

            entity.Property(e => e.Code).HasMaxLength(5);

            entity.HasOne(d => d.AbbrCatNavigation).WithMany(p => p.Abbreviations)
                .HasForeignKey(d => d.AbbrCat)
                .HasConstraintName("AbbreviationCategoriesAbbreviations");
        });

        modelBuilder.Entity<AbbreviationCategory>(entity =>
        {
            entity.HasKey(e => e.AbbrCat).HasName("PrimaryKey");

            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<Agl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL");

            entity.HasIndex(e => e.Code, "Code");

            entity.HasIndex(e => e.Name, "Name");
        });

        modelBuilder.Entity<AglDuplikaty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGL duplikaty");

            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.Delete).HasColumnType("bit");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Alias>(entity =>
        {
            entity.HasKey(e => new { e.Ord, e.Alias1 }).HasName("PrimaryKey");

            entity.Property(e => e.Alias1).HasColumnName("Alias");

            entity.HasOne(d => d.OrdNavigation).WithMany(p => p.Aliases)
                .HasForeignKey(d => d.Ord)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UnicodeDataAliases");
        });

        modelBuilder.Entity<AliasType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<Amsfont>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.Property(e => e.Tex).HasMaxLength(255);
        });

        modelBuilder.Entity<Amssymb>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Amssymb");

            entity.Property(e => e.Tex).HasMaxLength(255);
        });

        modelBuilder.Entity<Bidirectional>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.Property(e => e.Bidirectional1)
                .HasMaxLength(255)
                .HasColumnName("Bidirectional");
        });

        modelBuilder.Entity<BlockCategory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BlockType).HasMaxLength(255);
            entity.Property(e => e.Category).HasMaxLength(255);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.Property(e => e.Cat1).HasMaxLength(255);
            entity.Property(e => e.Cat2).HasMaxLength(255);
            entity.Property(e => e.Info).HasMaxLength(4);
        });

        modelBuilder.Entity<CharName>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.HasIndex(e => e.Name, "Name");
        });

        modelBuilder.Entity<Charset0>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Charset0");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Charset162>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Charset162");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Charset186>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Charset186");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Charset204>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Charset204");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Charset238>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Charset238");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Combination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("Combination");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Combinat).HasMaxLength(255);
        });

        modelBuilder.Entity<CombiningCharName>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.Meaning).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<ControlChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Control Chars");

            entity.Property(e => e.Abbr).HasMaxLength(255);
            entity.Property(e => e.AbbrCat).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
        });

        modelBuilder.Entity<CopyOfCharName>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Copy Of CharNames");

            entity.HasIndex(e => e.Name, "Name");
        });

        modelBuilder.Entity<Eufrak>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Eufrak");

            entity.Property(e => e.Tex).HasMaxLength(255);
        });

        modelBuilder.Entity<HtmlEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.Code, "Code");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Name, "Name");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Default)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.Glyph).HasMaxLength(255);
        });

        modelBuilder.Entity<LaTeX>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("LaTeX");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Encode).HasMaxLength(255);
        });

        modelBuilder.Entity<LangScript>(entity =>
        {
            entity.HasKey(e => new { e.Lang, e.Scpt }).HasName("PrimaryKey");

            entity.HasIndex(e => e.Lang, "Lang");

            entity.HasIndex(e => e.Scpt, "Scpt");

            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.Scpt).HasMaxLength(4);
        });

        modelBuilder.Entity<Languages1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Languages1");

            entity.Property(e => e.Code).HasMaxLength(3);
            entity.Property(e => e.Language).HasMaxLength(255);
            entity.Property(e => e.Ml)
                .HasMaxLength(1)
                .HasColumnName("ML");
            entity.Property(e => e.P).HasMaxLength(1);
        });

        modelBuilder.Entity<LatexMath>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("LatexMath");

            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.Tex).HasMaxLength(40);
        });

        modelBuilder.Entity<LatexMathT1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("LatexMathT1");

            entity.Property(e => e.Tex).HasMaxLength(255);
        });

        modelBuilder.Entity<LatexOt1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("LatexOT1");

            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.Tex).HasMaxLength(40);
        });

        modelBuilder.Entity<LatexT1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("LatexT1");

            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.Tex).HasMaxLength(40);
        });

        modelBuilder.Entity<Latexsym>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Latexsym");

            entity.Property(e => e.Tex).HasMaxLength(255);
        });

        modelBuilder.Entity<Latin1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Latin1");

            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.Tex).HasMaxLength(19);
        });

        modelBuilder.Entity<Letter>(entity =>
        {
            entity.HasKey(e => e.Letter1).HasName("PrimaryKey");

            entity.Property(e => e.Letter1).HasColumnName("Letter");
        });

        modelBuilder.Entity<Math1>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Math1");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Math3>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Math3");

            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Math5>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Math5");

            entity.Property(e => e.Code).HasMaxLength(50);
        });

        modelBuilder.Entity<Mathcal>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Mathcal");

            entity.Property(e => e.Tex).HasMaxLength(255);
        });

        modelBuilder.Entity<MtExtra>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("MT_Extra");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<PasteError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Paste Errors");

            entity.Property(e => e.EndCp)
                .HasMaxLength(255)
                .HasColumnName("EndCP");
            entity.Property(e => e.For).HasMaxLength(255);
            entity.Property(e => e.RangeName).HasMaxLength(255);
            entity.Property(e => e.StartCp)
                .HasMaxLength(255)
                .HasColumnName("StartCP");
            entity.Property(e => e.WritingSystem).HasMaxLength(255);
        });

        modelBuilder.Entity<RomanNumber>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Tex).HasMaxLength(50);
        });

        modelBuilder.Entity<RtcharName>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("RTCharNames");

            entity.HasIndex(e => e.Name, "Name").IsUnique();

            entity.Property(e => e.AltName).HasMaxLength(255);
            entity.Property(e => e.BaseCode).HasMaxLength(255);
            entity.Property(e => e.BaseName).HasMaxLength(255);
            entity.Property(e => e.Meaning).HasMaxLength(255);
        });

        modelBuilder.Entity<RtcontrolWord>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PrimaryKey");

            entity.ToTable("RTControlWords");

            entity.Property(e => e.Meaning).HasMaxLength(255);
            entity.Property(e => e.Uphrase)
                .HasMaxLength(255)
                .HasColumnName("UPhrase");
            entity.Property(e => e.Uword)
                .HasMaxLength(255)
                .HasColumnName("UWord");
        });

        modelBuilder.Entity<RtcontrolWordCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("RTControlWordCategories");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Meaning).HasMaxLength(255);
        });

        modelBuilder.Entity<Rtf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ID");

            entity.ToTable("RTF");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.ControlWord).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Section).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.V6)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
        });

        modelBuilder.Entity<Save>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("save");

            entity.HasIndex(e => e.Code, "Kod");

            entity.HasIndex(e => e.Order, "Order");

            entity.Property(e => e.Code).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Order).HasDefaultValue(1);
        });

        modelBuilder.Entity<ScriptsAndNotation>(entity =>
        {
            entity.HasKey(e => e.Keyword).HasName("PrimaryKey");
        });

        modelBuilder.Entity<StandardName>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.Ord }).HasName("PrimaryKey");

            entity.ToTable("Standard names");

            entity.Property(e => e.Code).HasMaxLength(6);
            entity.Property(e => e.Ord).HasDefaultValue((byte)0);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<StandardoweNazwy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Standardowe nazwy");

            entity.Property(e => e.Kod).HasMaxLength(4);
            entity.Property(e => e.Nazwy).HasMaxLength(255);
        });

        modelBuilder.Entity<StdName>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Stmaryrd>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("stmaryrd");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Tex).HasMaxLength(50);
        });

        modelBuilder.Entity<Symbol>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.ToTable("Symbol");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<SymbolSet>(entity =>
        {
            entity.HasKey(e => e.CodePoint).HasName("PrimaryKey");

            entity.ToTable("Symbol-Set");

            entity.HasIndex(e => e.CodePoint, "ID");

            entity.HasIndex(e => e.SymbolSet1, "SymbolSet");

            entity.Property(e => e.CodePoint).HasMaxLength(5);
            entity.Property(e => e.SymbolSet1).HasColumnName("SymbolSet");
        });

        modelBuilder.Entity<Symbole>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PrimaryKey");

            entity.ToTable("Symbole");

            entity.HasIndex(e => e.Kod, "Kod");

            entity.Property(e => e.Kod).HasMaxLength(4);
            entity.Property(e => e.Lp)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter");
            entity.Property(e => e.Matryca).HasMaxLength(144);
        });

        modelBuilder.Entity<Textcomp>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.ToTable("Textcomp");

            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.Tex).HasMaxLength(21);
        });

        modelBuilder.Entity<Uc>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.Property(e => e.Code).HasMaxLength(4);
            entity.Property(e => e.Tex).HasMaxLength(5);
        });

        modelBuilder.Entity<UcdBlock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.WritingSystemId, "WritingSystemID");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.End).HasDefaultValue(0);
            entity.Property(e => e.Range).HasMaxLength(255);
            entity.Property(e => e.Start).HasDefaultValue(0);
            entity.Property(e => e.WritingSystemId).HasColumnName("WritingSystemID");
        });

        modelBuilder.Entity<UcdBlockWritingSystem>(entity =>
        {
            entity.HasKey(e => new { e.UcdBlockId, e.WritingSystemId }).HasName("PrimaryKey");

            entity.ToTable("UcdBlock-WritingSystem");

            entity.HasIndex(e => e.UcdBlockId, "UcdBlockID");

            entity.HasIndex(e => e.WritingSystemId, "WritingSystemID");

            entity.Property(e => e.UcdBlockId).HasColumnName("UcdBlockID");
            entity.Property(e => e.WritingSystemId).HasColumnName("WritingSystemID");
        });

        modelBuilder.Entity<UcdRange>(entity =>
        {
            entity.HasKey(e => e.StartCp).HasName("PrimaryKey");

            entity.HasIndex(e => e.BlockRange, "BlockID");

            entity.HasIndex(e => e.WritingSystemId, "WritingSystemID");

            entity.Property(e => e.StartCp)
                .HasMaxLength(5)
                .HasColumnName("StartCP");
            entity.Property(e => e.EndCp)
                .HasMaxLength(5)
                .HasColumnName("EndCP");
            entity.Property(e => e.Language).HasMaxLength(255);
            entity.Property(e => e.RangeName).HasMaxLength(255);
            entity.Property(e => e.Standard).HasMaxLength(255);
            entity.Property(e => e.WritingSystemId).HasColumnName("WritingSystemID");

            entity.HasOne(d => d.BlockRangeNavigation).WithMany(p => p.UcdRanges)
                .HasForeignKey(d => d.BlockRange)
                .HasConstraintName("UcdBlocksUcdRanges");
        });

        modelBuilder.Entity<UcdRangesStartEnd>(entity =>
        {
            entity.HasKey(e => e.StartCp).HasName("PrimaryKey");

            entity.ToTable("UcdRanges-StartEnd");

            entity.HasIndex(e => e.BlockRange, "BlockRange");

            entity.HasIndex(e => e.End, "End").IsUnique();

            entity.HasIndex(e => e.Start, "Start").IsUnique();

            entity.Property(e => e.StartCp)
                .HasMaxLength(5)
                .HasColumnName("StartCP");
            entity.Property(e => e.EndCp)
                .HasMaxLength(5)
                .HasColumnName("EndCP");
        });

        modelBuilder.Entity<UnicodeData13>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("Pole1");

            entity.ToTable("UnicodeData13");

            entity.Property(e => e.Bidir).HasMaxLength(255);
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.Ctg).HasMaxLength(255);
            entity.Property(e => e.DecDigitVal).HasMaxLength(255);
            entity.Property(e => e.Decomposition).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DigitVal).HasMaxLength(255);
            entity.Property(e => e.Lower).HasMaxLength(255);
            entity.Property(e => e.Mirr).HasMaxLength(255);
            entity.Property(e => e.NumVal).HasMaxLength(255);
            entity.Property(e => e.OldDescription).HasMaxLength(255);
            entity.Property(e => e.Upper).HasMaxLength(255);
        });

        modelBuilder.Entity<UnicodeDatum>(entity =>
        {
            entity.HasKey(e => e.Ord).HasName("PrimaryKey");

            entity.HasIndex(e => e.CharName, "CharName");

            entity.HasIndex(e => e.NumVal, "NumVal");

            entity.Property(e => e.Bidir).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.Ctg).HasMaxLength(255);
            entity.Property(e => e.DecDigitVal).HasMaxLength(255);
            entity.Property(e => e.Decomposition).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DigitVal).HasMaxLength(255);
            entity.Property(e => e.Glyph).HasMaxLength(2);
            entity.Property(e => e.Lower).HasMaxLength(255);
            entity.Property(e => e.Mirr).HasMaxLength(255);
            entity.Property(e => e.OldDescription).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Upper).HasMaxLength(255);
        });

        modelBuilder.Entity<Webding>(entity =>
        {
            entity.HasKey(e => e.Char).HasName("PrimaryKey");

            entity.Property(e => e.Unicode).HasMaxLength(255);
        });

        modelBuilder.Entity<Wingding>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Char).HasMaxLength(255);
            entity.Property(e => e.CharName).HasMaxLength(255);
            entity.Property(e => e.Unicode).HasMaxLength(255);
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.HasKey(e => e.Word1).HasName("PrimaryKey");

            entity.Property(e => e.Word1).HasColumnName("Word");
        });

        modelBuilder.Entity<WritingSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => new { e.Abbr, e.Ext }, "Abbr").IsUnique();

            entity.HasIndex(e => e.Ctg, "Ctg").IsUnique();

            entity.HasIndex(e => new { e.Name, e.Type }, "FullName").IsUnique();

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Keywords, "Keywords").IsUnique();

            entity.HasIndex(e => e.ParentId, "ParentID");

            entity.HasIndex(e => e.Kind, "ScriptType");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Aliases).HasMaxLength(255);
            entity.Property(e => e.Ctg).HasMaxLength(2);
            entity.Property(e => e.Ext).HasMaxLength(10);
            entity.Property(e => e.Iso)
                .HasMaxLength(255)
                .HasColumnName("ISO");
            entity.Property(e => e.Kind).HasMaxLength(15);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Starting)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.Type).HasMaxLength(10);

            entity.HasOne(d => d.KindNavigation).WithMany(p => p.WritingSystems)
                .HasForeignKey(d => d.Kind)
                .HasConstraintName("WritingSystemKindsWritingSystems");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("WritingSystemsWritingSystems");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.WritingSystems)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("WritingSystemTypesWritingSystems");
        });

        modelBuilder.Entity<WritingSystemKind>(entity =>
        {
            entity.HasKey(e => e.Kind).HasName("PrimaryKey");

            entity.Property(e => e.Kind).HasMaxLength(15);
        });

        modelBuilder.Entity<WritingSystemType>(entity =>
        {
            entity.HasKey(e => e.Type).HasName("PrimaryKey");

            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<Zapfdingbat>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PrimaryKey");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
