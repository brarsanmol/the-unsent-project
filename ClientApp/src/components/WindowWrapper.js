import styled from "styled-components";
import {Button, Window, WindowContent, WindowHeader} from "react95";
import React from "react";

const Wrapper = styled.div`
  .window-header {
    display: flex;
    align-items: center;
    justify-content: space-between;
  }
  .close-icon {
    display: inline-block;
    width: 16px;
    height: 16px;
    margin-left: -1px;
    margin-top: -1px;
    transform: rotateZ(45deg);
    position: relative;
    &:before,
    &:after {
      content: '';
      position: absolute;
      background: black;
    }
    &:before {
      height: 100%;
      width: 3px;
      left: 50%;
      transform: translateX(-50%);
    }
    &:after {
      height: 3px;
      width: 100%;
      left: 0px;
      top: 50%;
      transform: translateY(-50%);
    }
  }
  .window {
    width: 25em;
  }
`;

const WindowWrapper = ({id, header, content, button}) => {
    return (
        <Wrapper>
            <Window id={id} className='window'>
                <WindowHeader className='window-header'>
                    {header}
                    <Button onClick={button}>
                        <span className='close-icon'/>
                    </Button>
                </WindowHeader>
                <WindowContent>
                    {content}
                </WindowContent>
            </Window>
        </Wrapper>
    );
}

export default WindowWrapper;