















def displaylessonnumber(lessonnumber):
    print('DisplayLessonNumber: Video ' + str(lessonnumber) + ' Lesson')

def displaylessonnumberasstring(lesson):
    print('DisplayLessonNumberAsString: ' + lesson)

def displaylessonnumberformatted(lessonnumber):
    return 'displaylessonnumberformatted: Video ' + str(lessonnumber) + ' Lesson'

lessonnumber = 4

displaylessonnumber(lessonnumber)

displaylessonnumberasstring('Video ' + str(lessonnumber) + ' Lesson')

lessonnumberformatted = displaylessonnumberformatted(lessonnumber)

print(lessonnumberformatted)