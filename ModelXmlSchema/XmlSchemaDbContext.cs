using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EntityFrameworkCore.Jet;
using System.Xml.Linq;
using System.IO.Compression;
using Microsoft.Office.Interop.Access.Dao;
using Access = Microsoft.Office.Interop.Access;

namespace ModelXmlSchema;

public sealed class XmlSchemaDbContext : DbContext
{
  public DbSet<SchemaFile> SchemaFiles { get; set; }

  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<UsedNamespace> UsedNamespaces { get; set; }

  public DbSet<TypeDef> Types { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Pattern> Patterns { get; set; }

  public DbSet<UnionMember> UnionMembers { get; set; }

  public DbSet<ListItem> ListItems { get; set; }

  public DbSet<Attribute> Attributes { get; set; }

  public DbSet<AttributeGroup> AttributeGroups { get; set; }

  public DbSet<AttributeGroupRef> AttributeGroupRefs { get; set; }

  public DbSet<Particle> Particles { get; set; }

  public DbSet<Group> Groups { get; set; }

  public Elements Elements
  {
    get
    {
      if (_Elements == null)
      {
        _Elements = new Elements(Particles);
      }

      return _Elements;
    }
  }
  private Elements? _Elements;

  public Dictionary<string, SchemaFile> FilesDictionary { get; set; } = null!;

  public Dictionary<string, Namespace> NamespaceDictionary { get; set; } = null!;

  public GroupRefs SchemaGroupRefs
  {
    get
    {
      if (_SchemaGroupRefs == null)
      {
        _SchemaGroupRefs = new GroupRefs(Particles);
      }

      return _SchemaGroupRefs;
    }
  }
  private GroupRefs? _SchemaGroupRefs;

  public string DbFilename { get; }

  public XmlSchemaDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
    SetLookups();
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@$"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DbFilename};");
    //optionsBuilder.EnableSensitiveDataLogging(true);
    //optionsBuilder.LogTo(message => Console.WriteLine(message));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UsedNamespace>()
      .HasKey(e => new { SchemaFileId = e.FileId, e.NamespaceId });

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.SchemaFile)
      .WithMany(e => e.UsedNamespaces)
      .HasForeignKey(e => e.FileId);

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.SchemaNamespace)
      .WithMany()
      .HasForeignKey(e => e.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .Property(type => type.IsComplex)
      .HasColumnType("bit");

    modelBuilder.Entity<TypeDef>()
      .HasDiscriminator<bool>("IsComplex")
      .HasValue<SimpleType>(false)
      .HasValue<ComplexType>(true);

    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.Namespace)
      .WithMany(e => e.Types)
      .HasForeignKey(e => e.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.BaseType)
      .WithMany()
      .HasForeignKey(e => e.BaseTypeId);

    modelBuilder.Entity<SimpleType>()
      .Property(type => type.HasPattern)
      .HasColumnType("bit");

    modelBuilder.Entity<SimpleType>()
      .Property(type => type.IsEnum)
      .HasColumnType("bit");

    modelBuilder.Entity<SimpleType>()
      .Property(type => type.IsUnion)
      .HasColumnType("bit");

    modelBuilder.Entity<SimpleType>()
      .Property(type => type.IsList)
      .HasColumnType("bit");

    modelBuilder.Entity<EnumValue>()
      .HasOne(item => item.OwnerType)
      .WithMany(subItem => subItem.EnumValues)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Pattern>()
      .HasOne(item => item.OwnerType)
      .WithMany(subItem => subItem.Patterns)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<UnionMember>()
      .HasOne(item => item.OwnerType)
      .WithMany(subItem => subItem.UnionMembers)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<UnionMember>()
      .HasOne(item => item.MemberType)
      .WithMany()
      .HasForeignKey(item => item.MemberTypeId);

    modelBuilder.Entity<ListItem>()
      .HasOne(item => item.MemberType)
      .WithMany()
      .HasForeignKey(item => item.MemberTypeId);

    modelBuilder.Entity<Particle>()
      .HasDiscriminator<ParticleType>("ParticleType")
      .HasValue<Any>(ParticleType.Any)
      .HasValue<Element>(ParticleType.Element)
      .HasValue<GroupRef>(ParticleType.GroupRef)
      .HasValue<All>(ParticleType.All)
      .HasValue<Choice>(ParticleType.Choice)
      .HasValue<Sequence>(ParticleType.Sequence);

    modelBuilder.Entity<Particle>()
      .Property("ParticleType").HasColumnType("byte");

    modelBuilder.Entity<Element>()
      .Property(e => e.Name)
      .HasColumnName("Name");

    modelBuilder.Entity<GroupRef>()
      .Property(e => e.RefName)
      .HasColumnName("Name");

    modelBuilder.Entity<Element>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<GroupRef>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<Particle>()
      .HasOne(p => p.ParentComplexType)
      .WithMany()
      .HasForeignKey(p => p.ComplexTypeId)
      .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Particle>()
        .HasOne(p => p.ParentGroup)
        .WithMany() // Assuming SchemaGroup has a collection of Particles
        .HasForeignKey(p => p.GroupId)
        .OnDelete(DeleteBehavior.Restrict);

    //modelBuilder.Entity<SchemaGroup>()
    //  .Navigation(e => e.ParentNamespace)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentNamespace)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentComplexType)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentGroup)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);


    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentParticle)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

  }

  internal void SetLookups()
  {
    var accessApp = new Access.ApplicationClass();
    accessApp.OpenCurrentDatabase(DbFilename, true);
    try
    {
      var database = accessApp.CurrentDb();
      SetLookup(database, "Types", "NamespaceId", "Namespaces");
      SetLookup(database, "Types", "BaseTypeId", "Types");
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
    finally
    {
      accessApp.CloseCurrentDatabase();
      accessApp.Quit();
    }

  }

  internal void SetLookup(Access.Dao.Database database, string tableName, string fieldName, string lookupTableName)
  {
    var field = database.TableDefs[tableName].Fields[fieldName];
    field.Properties["DisplayControl"].Value = 111; // acComboBox
    SetProperty(field, "RowSourceType", DataTypeEnum.dbText, "Table/Query");
    SetProperty(field, "RowSource", DataTypeEnum.dbText, lookupTableName);
    SetProperty(field, "ColumnCount", DataTypeEnum.dbInteger, 2);
    SetProperty(field, "ColumnWidths", DataTypeEnum.dbText, "0");
  }

  internal void SetProperty(Access.Dao.Field field, string propertyName, DataTypeEnum dataType, object value)
  {
    try
    {
      // Try to access the property if it already exists
      Property prop = field.Properties[propertyName];
      prop.Value = value;
    }
    catch (Exception)
    {
      // If the property does not exist, create and append it
      Property newProp = field.CreateProperty(propertyName, dataType, value);
      field.Properties.Append(newProp);
    }
  }
  public void LoadFiles()
  {
    FilesDictionary = SchemaFiles.ToDictionary(file => file.FileName);
    NamespaceDictionary = Namespaces.ToDictionary(ns => ns.Url ?? "");

    SchemaFiles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (SchemaFile file in args.NewItems!)
        {
          FilesDictionary.Add(file.FileName, file);
        }
      }
    };

    Namespaces.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Namespace ns in args.NewItems!)
        {
          NamespaceDictionary.Add(ns.Url, ns);
        }
      }
    };
  }

  public void LoadNamespaces()
  {
    //DisplayMessageEnabled = true;
    foreach (var ns in Namespaces
               .Include(ns => ns.Types)
            )
    {
      ns.TypesDictionary = ns.Types.ToDictionary(type => type.Name, type => type);
    }

    Types.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (TypeDef type in args.NewItems!)
        {
          NamespaceDictionary[type.Namespace.Url].TypesDictionary.Add(type.Name, type);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.EnumValues))
    {
      simpleType.EnumValuesDictionary = simpleType.EnumValues.ToDictionary(enumValue => enumValue.Name);
    }

    EnumValues.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (EnumValue enumValue in args.NewItems!)
        {
          (NamespaceDictionary[enumValue.OwnerType.Namespace.Url].TypesDictionary[enumValue.OwnerType.Name] as SimpleType)?.EnumValuesDictionary.Add(enumValue.Name, enumValue);
        }
      }
    };


    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.Patterns))
    {
      simpleType.PatternsDictionary = simpleType.Patterns.ToDictionary(pattern => pattern.Value);
    }


    Patterns.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Pattern pattern in args.NewItems!)
        {
          (NamespaceDictionary[pattern.OwnerType.Namespace.Url].TypesDictionary[pattern.OwnerType.Name] as SimpleType)?.PatternsDictionary.Add(pattern.Value, pattern);
        }
      }
    };


    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.UnionMembers))
    {
      simpleType.UnionMembersDictionary = simpleType.UnionMembers
        .ToDictionary(unionMember => unionMember.MemberType.FullName);
    }


    UnionMembers.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (UnionMember unionMember in args.NewItems!)
        {
          (NamespaceDictionary[unionMember.OwnerType.Namespace.Url].TypesDictionary[unionMember.OwnerType.Name] as SimpleType)?
            .UnionMembersDictionary.Add(unionMember.MemberType.FullName, unionMember);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.ListItems))
    {
      simpleType.ListItemsDictionary = simpleType.ListItems
        .ToDictionary(ListItem => ListItem.MemberType.FullName);
    }


    ListItems.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (ListItem ListItem in args.NewItems!)
        {
          (NamespaceDictionary[ListItem.OwnerType.Namespace.Url].TypesDictionary[ListItem.OwnerType.Name] as SimpleType)?
            .ListItemsDictionary.Add(ListItem.MemberType.FullName, ListItem);
        }
      }
    };
  }
}
