# Table of Contents

- [Example Labs](#example-labs)
  - [Getting Started](#getting-started)
  - [Organization](#organization)
  - [Submitting](#submitting)
  - [Rebase with `master`](#rebase-with-master)
- [Lab 1: FizzBuzz](#lab-1-fizzbuzz)
- [Lab 2: FizzBuzz (continued)](#lab-2-fizzbuzz-continued)

# Example Labs

This is where we will keep all of our lab work for this course. If you need a
refresher on git, see
[this high-level](https://rogerdudler.github.io/git-guide/) git guide.

## Getting Started

Clone this repository to your computer.

```shell
git clone https://github.com/braden337/Labs.git
```

From the `master` branch, make a new branch for yourself (you can use your first
name).

```shell
git checkout -b firstname
git push origin firstname
```

This branch will contain all of your completed work. You won't work in this
branch directly.

Now make another new branch from the one you just created, use your first name
again but append `-work`.

```shell
git checkout -b firstname-work
git push -u origin firstname-work
```

This is where you will do all of your work for each lab, so you can now delete
the other branch.

```shell
git branch -d firstname
```

## Organization

Let's use Lab 1: FizzBuzz as an example. In Visual Studio, create a new .NET
Core console app named FizzBuzz and save it at the root of this repository.

Your repository should look like this.

```shell
.gitignore
FizzBuzz/
README.md
```

## Submitting

Once you've completed a lab, you will create a pull request on GitHub comparing
your own branches (e.g. `firstname` compared to `firstname-work`).

Make sure you give the pull request a title that makes sense (e.g. Firstname:
Lab 2).

You can ask your peers to review the code in your pull request, give feedback
(comments in the pull request), or approve the merge into your `firstname`
branch.

## Rebase with `master`

The next time we have a new lab, I will add the instructions to this `README.md`
file. You can use the [table of contents](#contents) at the top for quick
navigation.

I'll also add my own solutions to each lab inside the `Solutions/` folder.

To get these updates you can rebase your `firstname-work` branch with the
`master` branch.

```shell
git checkout master
git pull
git checkout braden-work
git rebase master
git push -f
```

# Lab 1: FizzBuzz

From 1 to 100:

- print Fizz for numbers that are divisible 3
- print Buzz for numbers that are divisible by 5
- print FizzBuzz for numbers that are divisible by 3 and 5
- otherwise print the number

Example for 7 to 15:

```text
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
```

# Lab 2: FizzBuzz (continued)

View my solution to Lab 1 in the `Solutions/` folder.

Modify your FizzBuzz program from Lab 1 to _count down from 100_ instead of
counting up to 100.
