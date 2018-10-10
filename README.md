# PostgreSqlWithEF

Before Install on Console Manager : Install-Package Npgsql.EntityFramework 
After Add lines Your Project Config File :

<connectionStrings>
    <add name="xxxx"
         connectionString="User Id=xx;Password=xx;Host=xx;Database=xx;"
         providerName="Npgsql" />
  </connectionStrings>

 <system.data>
    <DbProviderFactories>
      <remove invariant="Npgsql" />
      <add name="Npgsql Data Provider" invariant="Npgsql" support="FF" description=".Net Framework Data Provider for Postgresql"
 type="Npgsql.NpgsqlFactory, Npgsql" />
    </DbProviderFactories>
  </system.data>
