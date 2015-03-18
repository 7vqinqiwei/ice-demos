Oracle Pro*C/C++ demo
=====================

This demo shows how to implement an Ice server that uses Oracle
through its Embedded SQL (Pro*C/C++) API.

It is a fairly simple demo that illustrates how to:

 - Map relational data to Ice objects, in particular convert between
   Ice and Oracle Pro*C/C++ types.
 - Associate an Oracle Pro*C/C++ context and database connection
   to each thread in the Ice server thread pool.
 - Use Ice default servants.


Building the demo
-----------------

On Linux or Unix, set ORACLE_HOME to point to your Oracle installation
home directory. Then build as usual.

On Windows with Visual Studio Project Files:

  - Oracle settings are configured using a property sheet named oracle
    that is attached to the server project configurations. Open the
    Visual Studio Property Manager from "View > Property Manager" menu.

  - Expand the server configuration and double click the oracle
    property sheet to edit it.

  - Click "Common Properties > User Macros" and set the ORACLE_HOME
    value to match your Oracle deployment.

  - Oracle 12c only includes 64-bit libraries and binaries. To build
    Win32 configurations you need to install the winnt_12c_client32.zip
    package available at the Oracle 12c download page:

    http://www.oracle.com/technetwork/database/enterprise-edition/downloads/database12c-win64-download-1968077.html

    and set the ORACLE_CLIENT_HOME value to match your deployment.

On Windows, when using nmake Makefiles, set the ORACLE_HOME and
ORACLE_CLIENT_HOME variables in your enviroment to match your Oracle
setup and review Makefile.mak.

Then build as usual.


Running the demo
----------------

- Setup an Oracle database with the traditional EMP/DEPT schema.
  With Oracle Server 12c, the corresponding SQL script is
  $ORACLE_HOME/rdbms/admin/utlsampl.sql.

- Review the Oracle.ConnectInfo property in the config.server file.
  You may need to change it to connect to your Oracle instance.

- Start the server:

  $ server

- Start the client in a separate window:

  $ client
