using lesson_5.Models;

namespace lesson_5.Services;

public interface IBlackBoardService
{
    Guid AddBlackBoard(BlackBoard blackBoard);
    bool UpdateBlackBoard(BlackBoard blackBoard);
    bool DeleteBlackBoard(Guid blackBoardId);
    BlackBoard? GetBlackBoardById(Guid blackBoardId);
    List<BlackBoard> GetAllBlackBoards();
}