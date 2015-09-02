var Square = React.createClass({
    render: function () {
        return (
            <td className="square">
                {this.props.piece}
            </td>
        );
    }
});

var ChessBoard = React.createClass({
    getInitialState: function() {
        return {model: []}
    },
    componenetWillMount: function() {
        var xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = function() {
            var model = JSON.parse(xhr.responseText);
            this.setState({ model: model });
        }.bind(this);
        xhr.send();
    },
    render: function () {
        return (
            <div className="chessBoard">
                <table>
                    <tbody>
                        <tr>
                            <Square piece="bRook" />
                            <Square piece="bKnight" />
                            <Square piece="bBishop" />
                            <Square piece="bQueen" />
                            <Square piece="bKing" />
                            <Square piece="bBishop" />
                            <Square piece="bKnight" />
                            <Square piece="bRook" />
                        </tr>
                        <tr>
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                            <Square piece="bPawn" />
                        </tr>
                        <tr>
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                        </tr>
                        <tr>
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                        </tr>
                        <tr>
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                        </tr>
                        <tr>
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                            <Square />
                        </tr>
                        <tr>
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                            <Square piece="wPawn" />
                        </tr>
                        <tr>
                            <Square piece="wRook" />
                            <Square piece="wKnight" />
                            <Square piece="wBishop" />
                            <Square piece="wQueen" />
                            <Square piece="wKing" />
                            <Square piece="wBishop" />
                            <Square piece="wKnight" />
                            <Square piece="wRook" />
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
});

React.render(
    <ChessBoard url="chess/model" />,
    document.getElementById('chessBoard')
);