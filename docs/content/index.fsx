(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../build"
#r "FsTfServing.dll"

open System
open FsTfServing
(**
Overview
-------
FsTfServing is a library 
*)


(**
*)

(**
See the samples included for further details.

Samples & documentation
-----------------------

 * [WordCount](wordcount.html) contains a "unreliable" spout example - emitted tuples do not require ack, could be lost in case of failure.

 * [Guaranteed](guaranteed.html) contains a "reliable" spout example - emitted tuples have unique ID and require ack.

 * [API Reference](reference/index.html) contains automatically generated documentation for public types, modules
   and functions in the library. 
 
Getting FsTfServing
----------------

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The FsTfServing library can be installed from <a href="https://nuget.org/packages/FsTfServing">NuGet</a> or <a href="https://www.myget.org/F/FsTfServing/">MyGet</a>:
      <pre>PM> Install-Package FsTfServing</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small">
      The library can also be tried out quickly as a Docker container, downloaded from <a href="https://hub.docker.com/r/prolucid/FsTfServing-samples/">docker hub</a>:
      <pre>$ docker run --name FsTfServing-samples -d -p 8080:8080 prolucid/FsTfServing-samples</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read the [library design notes][readme] to understand how it works.

The library is available under Apache 2.0 license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

Commercial support
--------------------------

Commercial training and support are available from the project sponsor: 
<a href="http://prolucid.ca/" target="_blank"><img src="http://prolucid.ca/wp-content/uploads/2014/06/Logo-.jpg" alt="Prolucid" style="height:30px" border="0" /></a>


  [content]: https://github.com/Prolucid/FsTfServing/tree/master/docs/content
  [gh]: https://github.com/Prolucid/FsTfServing
  [issues]: https://github.com/Prolucid/FsTfServing/issues
  [readme]: https://github.com/Prolucid/FsTfServing/blob/master/README.md
  [license]: https://github.com/Prolucid/FsTfServing/blob/master/LICENSE.md
*)
