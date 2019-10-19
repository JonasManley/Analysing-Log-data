<h1>Assignment #4 - Analysing Log data</h1>

<h2>Assignment Information</h2>

pdf at: https://datsoftlyngby.github.io/soft2019fall/DM/week-38/04-assignment.pdf

<h3>Log format</h3>

A log entry should contain the following:

- level Information, Warning, Error
- system System id
- instance Instance id
- action Action id
- timestamp Time of the event

<h2>Assignment</h2>

<h3>1 Create a dynamic analyser</h3>
Create a Finite State Automaton, that can handle log entries from a running
application (system). The automaton should be able hold states for a number
of running instances (Use case scenarios). The automation should be able to
monitor the following

- is the action legal according to the present state.
- is any instance stuck at a non-final (non-accepting) state.
- give a list of the running instances.

<h3>2 Create a Finite State Generator</h3>
Create an application that can create a Finite State Automaton to use in
the analyser 1. The generator should take regular expression, and a list of
actions (the alphabet) with max times as input.

Example: A(B|C)*D

- A Login, 100
- B List items, 50
- C Edit item, 500
- D Logout, 200


Tips:
• use the regex-to-nfa.pdf and slides for inspiration.
• template project can be found here:
https://github.com/datsoftlyngby/soft2018fall-dm-teaching-material.git
