Title: ADO TUI Devlog #1
Lead: Creating a TUI for Azure Devops
Published: 2025/01/02
Tags:
  - devlog
  - ADO
  - ADO TUI
  - csharp
---

Let it be no surprise that I *love* terminal ui apps.
I'm a big fan of neovim. I love lazygit.
I used to use terminal file explorers, but neovim with the oil plugin kinda overshadowed that. 

And being an obnoxious (neo)vim user, I'm always at a loss when I have to edit text in an other editor.

Enter Azure Boards (part of Azure Devops (ADO)).

I do really like the ADO suite for everything it does, but editing Program Board Items (PBIs) is a nightmare.
I'm really used to using markdown everywhere.
Even ADO supports it for the wiki plugin.
But not when writing anything in a PBI, be that comments, descriptions, acceptance criteria, you name it.

So I embarked on a super hacky system that allowed me to edit these workitems from my local machine with the editor I enjoy.
(**Note**: No seriously, this was reading and parsing YAML files with markdown content hacky. Maybe I'll show you one day.)

Then I saw the [gh-dash](https://console.dev/tools/gh-dash) tool through the [console.dev newsletter](https://console.dev),
and thought: *"Wait. Why am I not doing that?"*

So here we are.
A TUI for Azure devops.
Or atleast the start of one.
