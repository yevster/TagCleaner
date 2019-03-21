[![Build Status](https://yevbro.visualstudio.com/Tag%20Cleaner/_apis/build/status/Tag%20Cleaner-.NET%20Desktop-CI?branchName=master)](https://yevbro.visualstudio.com/Tag%20Cleaner/_build/latest?definitionId=3&branchName=master)

This utility has one purpose and one purpose only: to edit the title tags of audio files in a single directory to remove common prefixes.

# An Example
Imagine you ripped a CD whose metadata looks like this:

[![tagcleaner_before.png](https://s15.postimg.cc/bti8r96gb/tagcleaner_before.png)](https://postimg.cc/image/8mnp7mm07/)

If you load these files onto a portable device (such as an iPhone), all you'll see as track names will be "Dvořák: The Noon Witch, op. 108", which is useless as you already see that information in the "Album" field.

Instead of renaming every track by hand, you can simply open Tag Cleaner and browse into the rip directory.

[![tagcleaner.png](https://s19.postimg.cc/i1930mzf7/tagcleaner.png)](https://postimg.cc/image/c0be3kcsv/)

You can see in the "String to Remove" box, Tag Cleaner has already populated the redundant bit. All you have to do is click "Remove", and voila! The redundant part of the names is gone:

[![tagcleaner_after.png](https://s19.postimg.cc/kzan86rcj/tagcleaner_after.png)](https://postimg.cc/image/vm4gdlzhr/)

**Note:** Tag Cleaner only edits ID3 tags. It does not modify actual file names (feel free to file an issue if you want it to).

# Running TagCleaner

To run on Windows: unzip the zip file, run `TagCleaner.exe`.

To run on Mac or Linux: Download and install [Mono](https://www.mono-project.com/download/stable/#download-mac). Then, unzip the TagCleaner zip file, and run `mono TagCleaner.exe`.
