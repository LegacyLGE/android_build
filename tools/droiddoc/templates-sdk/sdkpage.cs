<?cs include:"doctype.cs" ?>
<?cs include:"macros.cs" ?>
<html>
<?cs if:sdk.redirect ?>
  <head>
    <title>Redirecting...</title>
    <meta http-equiv="refresh" content="0;url=<?cs var:toroot ?>sdk/<?cs
      if:sdk.redirect.path ?><?cs var:sdk.redirect.path ?><?cs
      else ?>index.html<?cs /if ?>">
    <link href="<?cs var:toroot ?>assets/android-developer-docs.css" rel="stylesheet" type="text/css" />
  </head>
<?cs else ?>
  <?cs include:"head_tag.cs" ?>
<?cs /if ?>
<body class="gc-documentation 
  <?cs if:(guide||develop||training||reference||tools||sdk) ?>develop<?cs
  elif:design ?>design<?cs
  elif:distribute ?>distribute<?cs
  /if ?>" itemscope itemtype="http://schema.org/CreativeWork">
  <a name="top"></a>
<?cs include:"header.cs" ?>


<div <?cs if:fullpage
?><?cs else
?>class="col-13" id="doc-col"<?cs /if ?> >

<?cs if:sdk.redirect ?>

<div class="g-unit">
  <div id="jd-content">
    <p>Redirecting to
    <a href="<?cs var:toroot ?>sdk/<?cs
      if:sdk.redirect.path ?><?cs var:sdk.redirect.path ?><?cs
      else ?>index.html<?cs /if ?>"><?cs
      if:sdk.redirect.path ?><?cs var:sdk.redirect.path ?><?cs
      else ?>Download the SDK<?cs /if ?>
    </a> ...</p>

<?cs else ?>
<?cs # else, if NOT redirect ...
#
#
# The following is for SDK/NDK pages
#
#
?>

<?cs if:header.hide ?><?cs else ?>
<h1 itemprop="name"><?cs var:page.title ?></h1>
<?cs /if ?>
  <div id="jd-content" itemprop="description">

<?cs if:sdk.not_latest_version ?>
  <div class="special">
    <p><strong>This is NOT the current Android SDK release.</strong></p>
    <p><a href="/sdk/index.html">Download the current Android SDK</a></p>
  </div>
<?cs /if ?>


<?cs if:ndk ?>
<?cs #
#
#
#
#
#
#
# the following is for the NDK
#
# (nested in if/else redirect)
#
#
#
#
?>

  <table class="download" id="download-table">
    <tr>
      <th>Platform</th>
      <th>Package</th>
      <th>Size</th>
      <th>MD5 Checksum</th>
  </tr>
  <tr>
    <td>Windows</td>
    <td>
  <a onClick="_gaq.push(['_trackEvent', 'Tools', 'Download NDK', 'Link <' + <?cs var:ndk.win_download ?> + '>']);"
     href="http://dl.google.com/android/ndk/<?cs var:ndk.win_download ?>"><?cs var:ndk.win_download ?></a>
    </td>
    <td><?cs var:ndk.win_bytes ?> bytes</td>
    <td><?cs var:ndk.win_checksum ?></td>
  </tr>
  <tr class="alt-color">
    <td>Mac OS X (intel)</td>
    <td>
  <a onClick="_gaq.push(['_trackEvent', 'Tools', 'Download NDK', 'Link <' + <?cs var:ndk.mac_download ?> + '>']);"
     href="http://dl.google.com/android/ndk/<?cs var:ndk.mac_download ?>"><?cs var:ndk.mac_download ?></a>
    </td>
    <td><?cs var:ndk.mac_bytes ?> bytes</td>
    <td><?cs var:ndk.mac_checksum ?></td>
  </tr>
  <tr>
    <td>Linux 32/64-bit (x86)</td>
    <td>
  <a onClick="_gaq.push(['_trackEvent', 'Tools', 'Download NDK', 'Link <' + <?cs var:ndk.linux_download ?> + '>']);"
     href="http://dl.google.com/android/ndk/<?cs var:ndk.linux_download ?>"><?cs var:ndk.linux_download ?></a>
    </td>
    <td><?cs var:ndk.linux_bytes ?> bytes</td>
    <td><?cs var:ndk.linux_checksum ?></td>
  </tr>
  </table>
  
  <?cs ########  HERE IS THE JD DOC CONTENT ######### ?>
  <?cs call:tag_list(root.descr) ?>

  <?cs else ?>
<?cs # end if NDK ... 
#
#
#
#
#
#
# the following is for the SDK
#
# (nested in if/else redirect and if/else NDK)
#
#
#
#
?>
  <?cs if:android.whichdoc == "online" ?>


<?cs ########  HERE IS THE JD DOC CONTENT FOR ONLINE ######### ?>
<?cs call:tag_list(root.descr) ?>

<div class="wrap">
<div class="pax col-13 online" style="display:none">




<p class="table-caption"><strong>ADT Bundle</strong></p>
  <table class="download">
    <tr>
      <th>Platform</th>
      <th>Package</th>
      <th>Size</th>
      <th>MD5 Checksum</th>
  </tr>
  <tr>
    <td>Windows</td>
    <td>
  <a onClick="return onDownload(this)" id="win-bundle"
     href="http://dl.google.com/android/sdk/<?cs var:sdk.win_bundle_download ?>"><?cs var:sdk.win_bundle_download ?></a>
    </td>
    <td><?cs var:sdk.win_bundle_bytes ?> bytes</td>
    <td><?cs var:sdk.win_bundle_checksum ?></td>
  </tr>
  <tr class="alt-color">
    <td>Mac OS X (intel)</td>
    <td>
  <a onClick="return onDownload(this)" id="mac-bundle"
     href="http://dl.google.com/android/sdk/<?cs var:ndk.mac_bundle_download ?>"><?cs var:sdk.mac_bundle_download ?></a>
    </td>
    <td><?cs var:sdk.mac_bundle_bytes ?> bytes</td>
    <td><?cs var:sdk.mac_bundle_checksum ?></td>
  </tr>
  <tr>
    <td>Linux 32/64-bit (x86)</td>
    <td>
  <a onClick="return onDownload(this)" id="linux-bundle"
     href="http://dl.google.com/android/sdk/<?cs var:sdk.linux_bundle_download ?>"><?cs var:sdk.linux_bundle_download ?></a>
    </td>
    <td><?cs var:sdk.linux_bundle_bytes ?> bytes</td>
    <td><?cs var:sdk.linux_bundle_checksum ?></td>
  </tr>
  </table>


<p class="table-caption"><strong>SDK Tools Only</strong></p>
  <table class="download">
    <tr>
      <th>Platform</th>
      <th>Package</th>
      <th>Size</th>
      <th>MD5 Checksum</th>
  </tr>
  <tr>
    <td rowspan="2">Windows</td>
    <td>
  <a onclick="return onDownload(this)" href="http://dl.google.com/android/<?cs var:sdk.win_download
?>"><?cs var:sdk.win_download ?></a>
    </td>
    <td><?cs var:sdk.win_bytes ?> bytes</td>
    <td><?cs var:sdk.win_checksum ?></td>
  </tr>
  <tr>
    <!-- blank TD from Windows rowspan -->
    <td>
  <a onclick="return onDownload(this)" id="win-tools" href="http://dl.google.com/android/<?cs
var:sdk.win_installer
?>"><?cs var:sdk.win_installer ?></a> (Recommended)
    </td>
    <td><?cs var:sdk.win_installer_bytes ?> bytes</td>
    <td><?cs var:sdk.win_installer_checksum ?></td>
  </tr>
  <tr class="alt-color">
    <td>Mac OS X (intel)</td>
    <td>
  <a onclick="return onDownload(this)" id="mac-tools" href="http://dl.google.com/android/<?cs
var:sdk.mac_download
?>"><?cs var:sdk.mac_download ?></a>
    </td>
    <td><?cs var:sdk.mac_bytes ?> bytes</td>
    <td><?cs var:sdk.mac_checksum ?></td>
  </tr>
  <tr>
    <td>Linux (i386)</td>
    <td>
  <a onclick="return onDownload(this)" id="linux-tools" href="http://dl.google.com/android/<?cs
var:sdk.linux_download
?>"><?cs var:sdk.linux_download ?></a>
    </td>
    <td><?cs var:sdk.linux_bytes ?> bytes</td>
    <td><?cs var:sdk.linux_checksum ?></td>
  </tr>
  </table>



  
  
  
  
<script>

  var os;
  var $bundlelink;
  var $toolslink;

  if (navigator.appVersion.indexOf("Win")!=-1) {
    os = "Windows";
    $bundlelink = $('#win-bundle');
    $toolslink = $('#win-tools');
  } else if (navigator.appVersion.indexOf("Mac")!=-1) {
    os = "Mac";
    $bundlelink = $('#mac-bundle');
    $toolslink = $('#mac-tools');
  } else if (navigator.appVersion.indexOf("Linux")!=-1) {
    os = "Linux";
    $bundlelink = $('#linux-bundle');
    $toolslink = $('#linux-tools');
  }

  if (os) {
    $('#not-supported').hide();

    /* set up primary adt download button */
    $('#download-bundle-button').show();
    $('#download-bundle-button').append("Download the SDK <br/><span class='small'>ADT Bundle for " + os + "</span>");
    $('#download-bundle-button').click(function() {return onDownload(this,true);}).attr('href', $bundlelink.attr('href'));

    /* set up sdk tools only button */
    $('#download-tools-button').show();
    $('#download-tools-button').append("Download the SDK Tools for " + os);
    $('#download-tools-button').click(function() {return onDownload(this,true);}).attr('href', $toolslink.attr('href'));
  } else {
    $('.pax').show();
  }

  function onDownload(link, button) {

    if (button) {
      $("#downloadForRealz").html($(link).text());
    } else {
      $("#downloadForRealz").html("Download " + $(link).text());
      $("a#next-link").html("Setting Up an Existing IDE").attr('href',toRoot + 'sdk/installing/index.html');
    }
    $("#downloadForRealz").attr('href',$(link).attr('href'));

    $("#tos").fadeIn('fast');
    $("#landing").fadeOut('fast');

    location.hash = "download";
    return false;
  }


  function onAgreeChecked() {
    if ($("input#agree").is(":checked")) {
      $("a#downloadForRealz").removeClass('disabled');
    } else {
      $("a#downloadForRealz").addClass('disabled');
    }
  }

  function onDownloadForRealz(link) {
    if ($("input#agree").is(':checked')) {
      $("div.sdk-terms").slideUp();
      $("#sdk-terms-form,.sdk-terms-intro").fadeOut('slow');
      $("#next-steps").fadeIn('slow');
      $("h1#tos-header").text('Get Ready to Code!');
      return true;
    } else {
      $("label#agreeLabel").parent().stop().animate({color: "#258AAF"}, 200,
        function() {$("label#agreeLabel").parent().stop().animate({color: "#222"}, 200)}
      );
      return false;
    }
  }

  $(window).hashchange( function(){
    console.log('hash: '+location.hash);
    if (location.hash == "") {
      location.reload();
    }
  });

</script>

</div><!-- end pax -->
</div><!-- end wrap -->


</div><!-- end the wrapper used for relative/absolute positions  -->
<?cs # THIS DIV WAS OPENED IN INDEX.JD ?>




  <?cs else ?> <?cs # end if online ?>

    <?cs if:sdk.preview ?><?cs # it's preview offline docs ?>
      <p>Welcome developers! We are pleased to provide you with a preview SDK for the upcoming
    Android 3.0 release, to give you a head-start on developing applications for it.
    </p>
    
      <p>See the <a
    href="<?cs var:toroot ?>sdk/preview/start.html">Getting Started</a> document for more information
    about how to set up the preview SDK and get started.</p>
    <style type="text/css">
    .non-preview { display:none; }
    </style>
    
    <?cs else ?><?cs # it's normal offline docs ?>
      
      <?cs ########  HERE IS THE JD DOC CONTENT FOR OFFLINE ######### ?>
      <?cs call:tag_list(root.descr) ?>
      <style type="text/css">
        body .offline { display:block; }
        body .online { display:none; }
      </style>      
      <script>
        $('.reqs').show();
      </script>
    <?cs /if ?>
    
  <?cs /if ?> <?cs # end if/else online ?>
  
<?cs /if ?> <?cs # end if/else NDK ?>

<?cs /if ?> <?cs # end if/else redirect ?>


</div><!-- end jd-content -->

<?cs if:!sdk.redirect ?>
<?cs include:"footer.cs" ?>
<?cs /if ?>

</div><!-- end g-unit -->

<?cs include:"trailer.cs" ?>

</body>
</html>



